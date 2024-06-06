using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IManufacturerRepository
{
    Task<IEnumerable<Manufacturer>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    Task<Manufacturer?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<Manufacturer, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(Manufacturer manufacturer, CancellationToken cancellationToken);

    Task RemoveAsync(Manufacturer manufacturer, CancellationToken cancellationToken);
}