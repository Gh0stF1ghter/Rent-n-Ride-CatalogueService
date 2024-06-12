using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IManufacturerRepository
{
    Task<IEnumerable<ManufacturerEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ManufacturerEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<ManufacturerEntity, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(ManufacturerEntity manufacturer, CancellationToken cancellationToken);

    Task UpdateAsync(ManufacturerEntity newManufacturer, CancellationToken cancellationToken);

    Task RemoveAsync(ManufacturerEntity manufacturer, CancellationToken cancellationToken);
}