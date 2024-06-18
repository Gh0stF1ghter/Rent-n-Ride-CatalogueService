using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public async Task<IEnumerable<ClientModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var clients = await clientRepository.GetRangeAsync(page, pageSize, cancellationToken);

        var clientModels = clients.Adapt<IEnumerable<ClientModel>>();

        return clientModels;
    }

    public async Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var client = await clientRepository.GetByIdAsync(id, cancellationToken);

        var clientModel = client.Adapt<ClientModel>();

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

        return clientToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var clientToDelete = await clientRepository.GetByIdAsync(id, cancellationToken);

        await clientRepository.RemoveAsync(clientToDelete, cancellationToken);
    }
}