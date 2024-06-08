using BLL.Services.Interfaces;
using BLL.ViewModels;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ModelNameService(IModelNameRepository repository) : IModelNameService
{
    public async Task<IEnumerable<ModelNameViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var modelNames = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var modelNameModels = modelNames.Adapt<IEnumerable<ModelNameViewModel>>();

        return modelNameModels;
    }

    public async Task<ModelNameViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, false, cancellationToken);

        var modelNameModel = modelName.Adapt<ModelNameViewModel>();

        return modelNameModel;
    }

    public async Task<ModelNameViewModel> AddAsync(CreateModelNameViewModel modelNameModel, CancellationToken cancellationToken)
    {
        var modelName = modelNameModel.Adapt<ModelName>();

        await repository.AddAsync(modelName, cancellationToken);

        var newModelNameModel = modelName.Adapt<ModelNameViewModel>();

        return newModelNameModel;
    }

    public async Task UpdateAsync(Guid id, CreateModelNameViewModel newModelNameModel, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, true, cancellationToken);

        newModelNameModel.Adapt(modelName);

        await repository.UpdateAsync(modelName, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, true, cancellationToken);

        await repository.RemoveAsync(modelName, cancellationToken);
    }
}