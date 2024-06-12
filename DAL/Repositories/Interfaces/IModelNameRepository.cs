using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IModelNameRepository : IRepositoryBase<ModelName>
{
    Task<IEnumerable<ModelName>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelName?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}