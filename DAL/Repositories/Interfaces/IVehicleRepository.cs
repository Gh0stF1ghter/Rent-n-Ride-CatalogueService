using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleRepository
{
    Task<IEnumerable<Vehicle>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<Vehicle?> GetByIdAsync(Guid id, bool trackingChanges, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<Vehicle, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(Vehicle vehicle, CancellationToken cancellationToken);

    Task UpdateAsync(Vehicle newVehicle, CancellationToken cancellationToken);

    Task RemoveAsync(Vehicle vehicle, CancellationToken cancellationToken);
}