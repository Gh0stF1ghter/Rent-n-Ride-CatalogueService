using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleRepository
{
    Task<IEnumerable<VehicleEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<VehicleEntity, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(VehicleEntity vehicle, CancellationToken cancellationToken);

    Task UpdateAsync(VehicleEntity newVehicle, CancellationToken cancellationToken);

    Task RemoveAsync(VehicleEntity vehicle, CancellationToken cancellationToken);
}