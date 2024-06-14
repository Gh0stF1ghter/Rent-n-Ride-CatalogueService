using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleClientHistoryRepository : IRepositoryBase<VehicleClientHistoryEntity>
{
    Task<IEnumerable<VehicleClientHistoryEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleClientHistoryEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}