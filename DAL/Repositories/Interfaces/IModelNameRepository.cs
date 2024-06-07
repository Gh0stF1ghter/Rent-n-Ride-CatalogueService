using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IModelNameRepository
{
    Task<IEnumerable<ModelName>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelName?> GetByIdAsync(Guid id, bool trackingChanges, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<ModelName, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(ModelName modelName, CancellationToken cancellationToken);

    Task UpdateAsync(ModelName newModelName, CancellationToken cancellationToken);

    Task RemoveAsync(ModelName modelName, CancellationToken cancellationToken);
}