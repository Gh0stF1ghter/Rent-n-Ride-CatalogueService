using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface ICarModelRepository
{
    Task<IEnumerable<CarModelEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<CarModelEntity?> GetByIdAsync(Guid id, bool trackingChanges, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<CarModelEntity, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(CarModelEntity modelName, CancellationToken cancellationToken);

    Task UpdateAsync(CarModelEntity newModelName, CancellationToken cancellationToken);

    Task RemoveAsync(CarModelEntity modelName, CancellationToken cancellationToken);
}