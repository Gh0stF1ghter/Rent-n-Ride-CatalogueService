using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleClientHistoryRepository
{
    Task<IEnumerable<VehicleClientHistoryEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleClientHistoryEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<VehicleClientHistoryEntity, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(VehicleClientHistoryEntity vehicleClientHistory, CancellationToken cancellationToken);

    Task UpdateAsync(VehicleClientHistoryEntity vehicleClientHistory, CancellationToken cancellationToken);

    Task RemoveAsync(VehicleClientHistoryEntity vehicleClientHistory, CancellationToken cancellationToken);
}