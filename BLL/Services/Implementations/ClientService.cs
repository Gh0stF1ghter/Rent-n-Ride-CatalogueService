using BLL.Services.Interfaces;
using DAL.Mappers;
using DAL.Models;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementations;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public async Task<IEnumerable<ClientModel>> GetRangeAsync(int pageSize, int page, CancellationToken cancellationToken)
    {
        var clients = await clientRepository.GetRangeAsync(pageSize, page, cancellationToken);

        var clientModels = new List<ClientModel>();

        foreach (var client in clients)
        {
            var clientModel = ClientMapper.Map(client);

            clientModels.Add(clientModel);
        }

        return clientModels;
    }

    public async Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var client = await clientRepository.GetByIdAsync(id, false, cancellationToken);

        var clientModel = ClientMapper.Map(client);

        return clientModel;
    }

    public async Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken)
    {
        var newClient = ClientMapper.Map(clientModel);

        await clientRepository.AddAsync(newClient, cancellationToken);

        var newClientModel = ClientMapper.Map(newClient);

        return newClientModel;
    }

    public async Task<ClientModel> UpdateAsync(Guid id, ClientModel newClientModel, CancellationToken cancellationToken)
    {
        var clientToUpdate = await clientRepository.GetByIdAsync(id, true, cancellationToken);

        clientToUpdate = ClientMapper.Map(newClientModel);

        await clientRepository.UpdateAsync(clientToUpdate, cancellationToken);

        var clientToReturn = ClientMapper.Map(clientToUpdate);

        return clientToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var clientToDelete = await clientRepository.GetByIdAsync(id, true, cancellationToken);

        await clientRepository.RemoveAsync(clientToDelete, cancellationToken);
    }
}