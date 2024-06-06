using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IManufacturerRepository
{
    public Task<IEnumerable<Manufacturer>> GetManufacturersRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Manufacturer?> GetManufacturerByIdAsync(int id, CancellationToken cancellationToken);

    public Task<bool> IsManufacturerExists(Expression<Func<Manufacturer, bool>> predicate, CancellationToken cancellationToken);

    public void AddManufacturer(Manufacturer manufacturer);
    public void RemoveManufacturer(Manufacturer manufacturer);
}