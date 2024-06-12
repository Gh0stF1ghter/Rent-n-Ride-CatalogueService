using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IModelNameRepository : IRepositoryBase<ModelName>
{
    Task<IEnumerable<ModelName>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelName?> GetByIdAsync(Guid id, bool trackingChanges, CancellationToken cancellationToken);
}