using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IVehicleRepository : IRepositoryBase<Vehicle>
{
    Task<IEnumerable<Vehicle>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<Vehicle?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}