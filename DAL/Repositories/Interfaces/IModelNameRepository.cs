using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IModelNameRepository
{
    Task<IEnumerable<ModelName>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelName?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<ModelName, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(ModelName model, CancellationToken cancellationToken);

    Task RemoveAsync(ModelName model, CancellationToken cancellationToken);
}