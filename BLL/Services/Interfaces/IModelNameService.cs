using BLL.Models;

namespace BLL.Services.Interfaces;

public interface IModelNameService
{
    Task<IEnumerable<ModelNameModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelNameModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ModelNameModel> AddAsync(ModelNameModel modelNameModel, CancellationToken cancellationToken);

    Task<ModelNameModel> UpdateAsync(ModelNameModel newModelNameModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
