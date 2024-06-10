using DAL.Models;

namespace BLL.Services.Interfaces;

public interface IClientService
{
    Task<IEnumerable<ClientModel>> GetRangeAsync(int pageSize, int page, CancellationToken cancellationToken);

    Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken);

    Task UpdateAsync(Guid id, ClientModel newClientModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
