using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.Extensions.Caching.Distributed;

namespace BLL.Services.Implementations;

public class ClientService(IClientRepository clientRepository, IDistributedCache distributedCache) : IClientService
{
    public async Task<IEnumerable<ClientModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var key = nameof(IEnumerable<ClientModel>) + page + pageSize;

        var cache = await distributedCache.GetDataFromCacheAsync<IEnumerable<ClientModel>>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var clients = await clientRepository.GetRangeAsync(page, pageSize, cancellationToken);

        var clientModels = clients.Adapt<IEnumerable<ClientModel>>();

        var cacheLifetime = TimeSpan.FromMinutes(5);
        await distributedCache.CacheData(clientModels, cacheLifetime, key, cancellationToken);

        return clientModels;
    }

    public async Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = nameof(ClientModel) + id;

        var cache = await distributedCache.GetDataFromCacheAsync<ClientModel>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var client = await clientRepository.GetByIdAsync(id, cancellationToken);

        var clientModel = client.Adapt<ClientModel>();

        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(cache, cacheLifetime, key, cancellationToken);

        return clientModel;
    }

    public async Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken)
    {
        var newClient = clientModel.Adapt<ClientEntity>();

        await clientRepository.AddAsync(newClient, cancellationToken);

        var newClientModel = newClient.Adapt<ClientModel>();

        return newClientModel;
    }

    public async Task<ClientModel> UpdateAsync(ClientModel newClientModel, CancellationToken cancellationToken)
    {
        var clientToUpdate = await clientRepository.GetByIdAsync(newClientModel.Id, cancellationToken);

        newClientModel.Adapt(clientToUpdate);

        await clientRepository.UpdateAsync(clientToUpdate, cancellationToken);

        var clientToReturn = clientToUpdate.Adapt<ClientModel>();

        var key = nameof(ClientModel) + clientToReturn.Id;
        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(clientToReturn, cacheLifetime, key, cancellationToken);

        return clientToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var clientToDelete = await clientRepository.GetByIdAsync(id, cancellationToken);

        await clientRepository.RemoveAsync(clientToDelete, cancellationToken);

        var key = nameof(ClientModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);
    }
}