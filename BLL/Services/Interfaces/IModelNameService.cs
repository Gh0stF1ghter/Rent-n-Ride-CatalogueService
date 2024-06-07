using BLL.ViewModels;

namespace BLL.Services.Interfaces;

public interface IModelNameService
{
    Task<IEnumerable<ModelNameViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ModelNameViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ModelNameViewModel> AddAsync(CreateModelNameViewModel modelNameModel, CancellationToken cancellationToken);

    Task UpdateAsync(Guid id, CreateModelNameViewModel newModelNameModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
