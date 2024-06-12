using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IManufacturerRepository : IRepositoryBase<Manufacturer>
{
    Task<IEnumerable<Manufacturer>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<Manufacturer?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}