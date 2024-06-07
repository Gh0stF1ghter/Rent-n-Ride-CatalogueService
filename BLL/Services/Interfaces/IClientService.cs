using BLL.ViewModels;
using DAL.Models;

namespace BLL.Services.Interfaces;

public interface IClientService
{
    Task<IEnumerable<ClientViewModel>> GetRangeAsync(int pageSize, int page, CancellationToken cancellationToken);

    Task<ClientViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ClientViewModel> AddAsync(CreateClientViewModel clientModel, CancellationToken cancellationToken);

    Task UpdateAsync(Guid id, CreateClientViewModel newClientModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
