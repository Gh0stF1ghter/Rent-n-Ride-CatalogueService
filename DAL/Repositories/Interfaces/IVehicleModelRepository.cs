using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IVehicleModelRepository
{
    Task<IEnumerable<VehicleModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<VehicleModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<VehicleModel, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(VehicleModel model, CancellationToken cancellationToken);

    Task RemoveAsync(VehicleModel model, CancellationToken cancellationToken);
}