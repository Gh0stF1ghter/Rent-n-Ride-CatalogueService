using BLL.ViewModels;

namespace BLL.Services.Interfaces;

public interface IVehicleClientHistoryService
{
    Task<IEnumerable<VchViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VchViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<VchViewModel> AddAsync(CreateVchViewModel vchModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}