using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IModelRepository
{
    public Task<IEnumerable<Model>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Model?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken);

    public Task AddAsync(Model model, CancellationToken cancellationToken);
    public Task RemoveAsync(Model model, CancellationToken cancellationToken);
}