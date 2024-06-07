using BLL.Services.Interfaces;
using BLL.ViewModels;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public async Task<IEnumerable<ClientViewModel>> GetRangeAsync(int pageSize, int page, CancellationToken cancellationToken)
    {
        var clients = await clientRepository.GetRangeAsync(pageSize, page, cancellationToken);

        var clientModels = clients.Adapt<IEnumerable<ClientViewModel>>();

        return clientModels;
    }

    public async Task<ClientViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var client = await clientRepository.GetByIdAsync(id, false, cancellationToken);

        var clientModel = client.Adapt<ClientViewModel>();

        return clientModel;
    }

    public async Task<ClientViewModel> AddAsync(CreateClientViewModel clientModel, CancellationToken cancellationToken)
    {
        var newClient = clientModel.Adapt<Client>();

        await clientRepository.AddAsync(newClient, cancellationToken);

        var newClientModel = newClient.Adapt<ClientViewModel>();

        return newClientModel;
    }

    public async Task UpdateAsync(Guid id, CreateClientViewModel newClientModel, CancellationToken cancellationToken)
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