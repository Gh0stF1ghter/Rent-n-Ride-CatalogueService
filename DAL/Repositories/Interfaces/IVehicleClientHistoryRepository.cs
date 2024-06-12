using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleClientHistoryRepository : IRepositoryBase<VehicleClientHistory>
{
    Task<IEnumerable<VehicleClientHistory>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleClientHistory?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}