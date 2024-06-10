using BLL.Services.Interfaces;
using DAL.Mappers;
using DAL.Models;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementations;

public class ModelNameService(IModelNameRepository repository) : IModelNameService
{
    public async Task<IEnumerable<ModelNameModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var modelNames = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var modelNameModels = new List<ModelNameModel>();

        foreach (var modelName in modelNames)
        {
            var modelNameModel = ModelNameMapper.Map(modelName);

            modelNameModels.Add(modelNameModel); 
        }

        return modelNameModels;
    }

    public async Task<ModelNameModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, false, cancellationToken);

        var modelNameModel = ModelNameMapper.Map(modelName);

        return modelNameModel;
    }

    public async Task<ModelNameModel> AddAsync(ModelNameModel modelNameModel, CancellationToken cancellationToken)
    {
        var modelName = ModelNameMapper.Map(modelNameModel);

        await repository.AddAsync(modelName, cancellationToken);

        var newModelNameModel = ModelNameMapper.Map(modelName);

        return newModelNameModel;
    }

    public async Task<ModelNameModel> UpdateAsync(Guid id, ModelNameModel newModelNameModel, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, true, cancellationToken);

        modelName = ModelNameMapper.Map(newModelNameModel);

        await repository.UpdateAsync(modelName, cancellationToken);

        var modeNameToReturn = ModelNameMapper.Map(modelName);

        return modeNameToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, true, cancellationToken);

        await repository.RemoveAsync(modelName, cancellationToken);
    }
}