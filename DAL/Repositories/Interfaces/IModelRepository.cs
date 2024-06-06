using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IModelRepository
{
    Task<IEnumerable<Model>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    Task<Model?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(Model model, CancellationToken cancellationToken);

    Task RemoveAsync(Model model, CancellationToken cancellationToken);
}