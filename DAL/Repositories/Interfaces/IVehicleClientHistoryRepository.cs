using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleClientHistoryRepository
{
    public Task<IEnumerable<VehicleClientHistory>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<VehicleClientHistory?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<VehicleClientHistory, bool>> predicate, CancellationToken cancellationToken);

    public Task AddAsync(VehicleClientHistory vehicleClientHistory, CancellationToken cancellationToken);

    public Task RemoveAsync(VehicleClientHistory vehicleClientHistory, CancellationToken cancellationToken);
}