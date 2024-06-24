using BLL.Exceptions.ExceptionMessages;
using BLL.Exceptions;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.Extensions.Caching.Distributed;

namespace BLL.Services.Implementations;

public class VehicleClientHistoryService(IVehicleClientHistoryRepository repository, IDistributedCache distributedCache) : IVehicleClientHistoryService
{
    public async Task<IEnumerable<VehicleClientHistoryModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var vehicleClientHistories = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleClientHistoryModels = vehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryModel>>();

        return vehicleClientHistoryModels;
    }

    public async Task<VehicleClientHistoryModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = nameof(VehicleClientHistoryModel) + id;

        var cache = await distributedCache.GetDataFromCacheAsync<VehicleClientHistoryModel>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var vch = await repository.GetByIdAsync(id, cancellationToken);

        var vchModel = vch.Adapt<VehicleClientHistoryModel>();

        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(vchModel, cacheLifetime, key, cancellationToken);

        return vchModel;
    }

    public async Task<VehicleClientHistoryModel> AddAsync(VehicleClientHistoryModel vchModel, CancellationToken cancellationToken)
    {
        var vch = vchModel.Adapt<VehicleClientHistoryEntity>();

        await repository.AddAsync(vch, cancellationToken);

        var newVchModel = vch.Adapt<VehicleClientHistoryModel>();

        return newVchModel;
    }

    public async Task<VehicleClientHistoryModel> UpdateAsync(VehicleClientHistoryModel vchModel, CancellationToken cancellationToken)
    {
        var newVchModel = await repository.GetByIdAsync(vchModel.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.NotFound(nameof(VehicleClientHistoryEntity), vchModel.Id));

        vchModel.Adapt(newVchModel);

        await repository.UpdateAsync(newVchModel, cancellationToken);

        var vchModelToReturn = vchModel.Adapt<VehicleClientHistoryModel>();

        var key = nameof(VehicleClientHistoryModel) + vchModelToReturn.Id;
        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(vchModelToReturn, cacheLifetime, key, cancellationToken);

        return vchModelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.NotFound(nameof(VehicleClientHistoryEntity), id));

        await repository.RemoveAsync(modelName, cancellationToken);

        var key = nameof(VehicleClientHistoryModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);
    }
}