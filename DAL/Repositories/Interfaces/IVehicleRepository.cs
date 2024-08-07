using DAL.Entities;
using DAL.QueryParameters;

namespace DAL.Repositories.Interfaces;

public interface IVehicleRepository : IRepositoryBase<VehicleEntity>
{
    Task<IEnumerable<VehicleEntity>> GetRangeAsync(int page, int pageSize, VehicleParameters? parameters, CancellationToken cancellationToken);

    Task<VehicleEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}