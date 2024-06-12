using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IVehicleRepository : IRepositoryBase<VehicleEntity>
{
    Task<IEnumerable<VehicleEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}