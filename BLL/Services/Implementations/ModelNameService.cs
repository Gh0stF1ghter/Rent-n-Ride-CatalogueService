using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Models;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class ModelNameService(IModelNameRepository repository) : IModelNameService
{
    public async Task<IEnumerable<ModelNameModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var modelNames = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var modelNameModels = modelNames.Adapt<IEnumerable<ModelNameModel>>();

        return modelNameModels;
    }

    public async Task<ModelNameModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, false, cancellationToken);

        var modelNameModel = modelName.Adapt<ModelNameModel>();

        return modelNameModel;
    }

    public async Task<ModelNameModel> AddAsync(ModelNameModel modelNameModel, CancellationToken cancellationToken)
    {
        var modelName = modelNameModel.Adapt<ModelName>();

        await repository.AddAsync(modelName, cancellationToken);

        var newModelNameModel = modelName.Adapt<ModelNameModel>();

        return newModelNameModel;
    }

    public async Task UpdateAsync(Guid id, ModelNameModel newModelNameModel, CancellationToken cancellationToken)
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