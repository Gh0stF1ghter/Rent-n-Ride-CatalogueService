using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IVehicleRepository
{
    public Task<IEnumerable<Vehicle>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Vehicle?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<Vehicle, bool>> predicate, CancellationToken cancellationToken);

    public Task AddAsync(Vehicle vehicle, CancellationToken cancellationToken);
    public Task RemoveAsync(Vehicle vehicle, CancellationToken cancellationToken);
}