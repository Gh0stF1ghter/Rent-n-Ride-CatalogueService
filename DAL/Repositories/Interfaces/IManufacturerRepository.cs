using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IManufacturerRepository : IRepositoryBase<ManufacturerEntity>
{
    Task<IEnumerable<ManufacturerEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ManufacturerManufacturerEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}