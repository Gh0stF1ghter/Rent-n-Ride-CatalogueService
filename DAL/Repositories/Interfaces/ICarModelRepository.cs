using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface ICarModelRepository : IRepositoryBase<CarModelEntity>
{
    Task<IEnumerable<CarModelEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<CarModelEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}