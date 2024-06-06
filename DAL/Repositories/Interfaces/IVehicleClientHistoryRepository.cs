using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleClientHistoryRepository
{
    Task<IEnumerable<VehicleClientHistory>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleClientHistory?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<VehicleClientHistory, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(VehicleClientHistory vehicleClientHistory, CancellationToken cancellationToken);

    Task RemoveAsync(VehicleClientHistory vehicleClientHistory, CancellationToken cancellationToken);
}