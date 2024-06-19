using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.Extensions.Caching.Distributed;

namespace BLL.Services.Implementations;

public class CarModelService(ICarModelRepository repository, IDistributedCache distributedCache) : ICarModelService
{
    public async Task<IEnumerable<CarModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var key = nameof(IEnumerable<CarModel>) + page + pageSize;

        var cache = await distributedCache.GetDataFromCacheAsync<IEnumerable<CarModel>>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var modelNames = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var modelNameModels = modelNames.Adapt<IEnumerable<CarModel>>();

        var cacheLifetime = TimeSpan.FromMinutes(3);
        await distributedCache.CacheData(modelNameModels, cacheLifetime, key, cancellationToken);

        return modelNameModels;
    }

    public async Task<CarModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = nameof(CarModel) + id;

        var cache = await distributedCache.GetDataFromCacheAsync<CarModel>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var modelName = await repository.GetByIdAsync(id, cancellationToken);

        var modelNameModel = modelName.Adapt<CarModel>();

        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(modelNameModel, cacheLifetime, key, cancellationToken);

        return modelNameModel;
    }

    public async Task<CarModel> AddAsync(CarModel modelNameModel, CancellationToken cancellationToken)
    {
        var modelName = modelNameModel.Adapt<CarModelEntity>();

        await repository.AddAsync(modelName, cancellationToken);

        var newModelNameModel = modelName.Adapt<CarModel>();

        return newModelNameModel;
    }

    public async Task<CarModel> UpdateAsync(CarModel newModelNameModel, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(newModelNameModel.Id, cancellationToken);

        newModelNameModel.Adapt(modelName);

        await repository.UpdateAsync(modelName, cancellationToken);

        var modeNameToReturn = modelName.Adapt<CarModel>();

        var key = nameof(CarModel) + modeNameToReturn.Id;
        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(modeNameToReturn, cacheLifetime, key, cancellationToken);

        return modeNameToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, cancellationToken);

        await repository.RemoveAsync(modelName, cancellationToken);

        var key = nameof(CarModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);
    }
}