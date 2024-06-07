﻿using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Models;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public async Task<IEnumerable<ClientModel>> GetRangeAsync(int pageSize, int page, CancellationToken cancellationToken)
    {
        var clients = await clientRepository.GetRangeAsync(pageSize, page, cancellationToken);

        var clientModels = clients.Adapt<IEnumerable<ClientModel>>();

        return clientModels;
    }

    public async Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var client = await clientRepository.GetByIdAsync(id, false, cancellationToken);

        var clientModel = client.Adapt<ClientModel>();

        return clientModel;
    }

    public async Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken)
    {
        var newClient = clientModel.Adapt<Client>();

        await clientRepository.AddAsync(newClient, cancellationToken);

        var newClientModel = newClient.Adapt<ClientModel>();

        return newClientModel;
    }

    public async Task UpdateAsync(Guid id, ClientModel newClientModel, CancellationToken cancellationToken)
    {
        var clientToUpdate = await clientRepository.GetByIdAsync(id, true, cancellationToken);

        newClientModel.Adapt(clientToUpdate);

        await clientRepository.UpdateAsync(clientToUpdate, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var clientToDelete = await clientRepository.GetByIdAsync(id, true, cancellationToken);

        await clientRepository.RemoveAsync(clientToDelete, cancellationToken);
    }
}