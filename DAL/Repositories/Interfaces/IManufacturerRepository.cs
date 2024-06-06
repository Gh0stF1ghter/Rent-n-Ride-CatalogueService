using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IManufacturerRepository
{
    public Task<IEnumerable<Manufacturer>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Manufacturer?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<Manufacturer, bool>> predicate, CancellationToken cancellationToken);

    public Task AddAsync(Manufacturer manufacturer, CancellationToken cancellationToken);

    public Task RemoveAsync(Manufacturer manufacturer, CancellationToken cancellationToken);
}