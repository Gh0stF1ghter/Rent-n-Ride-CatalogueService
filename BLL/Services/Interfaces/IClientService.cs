using DAL.Models;

namespace BLL.Services.Interfaces;
internal interface IClientService
{
    Task<IEnumerable<ClientModel>> GetRangeAsync(int pageSize, int page, CancellationToken cancellationToken);

    Task<ClientModel> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<ClientModel> AddAsync(ClientModel clientModel);

    Task UpdateAsync(int id, ClientModel newClientModel);

    Task DeleteAsync(int id);
}
