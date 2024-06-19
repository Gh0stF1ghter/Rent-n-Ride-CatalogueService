using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.Extensions.Caching.Distributed;

namespace BLL.Services.Implementations;

public class ManufacturerService(IManufacturerRepository repository, IDistributedCache distributedCache) : IManufacturerService
{
    public async Task<IEnumerable<ManufacturerModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var manufacturerModels = manufacturers.Adapt<IEnumerable<ManufacturerModel>>();

        return manufacturerModels;
    }

    public async Task<ManufacturerModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = nameof(ManufacturerModel) + id;

        var cache = await distributedCache.GetDataFromCacheAsync<ManufacturerModel>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var manufacturer = await repository.GetByIdAsync(id, cancellationToken);

        var manufacturerModel = manufacturer.Adapt<ManufacturerModel>();

        var cacheLifetime = TimeSpan.FromMinutes(5);
        await distributedCache.CacheData(manufacturerModel, cacheLifetime, key, cancellationToken);

        return manufacturerModel;
    }

    public async Task<ManufacturerModel> AddAsync(ManufacturerModel manufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = manufacturerModel.Adapt<ManufacturerEntity>();

        await repository.AddAsync(manufacturer, cancellationToken);

        var newManufacturerModel = manufacturer.Adapt<ManufacturerModel>();

        return newManufacturerModel;
    }

    public async Task<ManufacturerModel> UpdateAsync(ManufacturerModel newManufacturerModel, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(newManufacturerModel.Id, cancellationToken);

        newManufacturerModel.Adapt(manufacturer);

        await repository.UpdateAsync(manufacturer, cancellationToken);

        var manufacturerToReturn = manufacturer.Adapt<ManufacturerModel>();

        var key = nameof(ManufacturerModel) + manufacturerToReturn.Id;
        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(manufacturerToReturn, cacheLifetime, key, cancellationToken);

        return manufacturerToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await repository.GetByIdAsync(id, cancellationToken);

        await repository.RemoveAsync(manufacturer, cancellationToken);

        var key = nameof(ManufacturerModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);
    }
}