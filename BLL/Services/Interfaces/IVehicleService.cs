using DAL.Models;

namespace BLL.Services.Interfaces;
internal interface IVehicleService
{
    Task<IEnumerable<VehicleModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleModel> GetByIdAsync(int id, CancellationToken cancellationToken);

    Task<VehicleModel> AddAsync(VehicleModel vehicleModel, CancellationToken cancellationToken);

    Task UpdateAsync(int id, VehicleModel newVehicleModel);

    Task DeleteAsync(int id);
}