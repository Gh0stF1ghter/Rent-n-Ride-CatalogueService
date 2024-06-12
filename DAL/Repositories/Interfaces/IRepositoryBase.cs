using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<IQueryable<TEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<IQueryable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> condition, CancellationToken cancellationToken);

    Task AddAsync(TEntity entity, CancellationToken cancellationToken);

    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);

    Task RemoveAsync(TEntity entity, CancellationToken cancellationToken);
}