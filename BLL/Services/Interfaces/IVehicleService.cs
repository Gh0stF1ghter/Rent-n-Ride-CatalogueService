using BLL.ViewModels;

namespace BLL.Services.Interfaces;

public interface IVehicleService
{
    Task<IEnumerable<VehicleViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<VehicleViewModel> AddAsync(CreateVehicleViewModel vehicleModel, CancellationToken cancellationToken);

    Task UpdateAsync(Guid id, CreateVehicleViewModel newVehicleModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}