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

public class VehicleService(IVehicleRepository repository, IDistributedCache distributedCache) : IVehicleService
{
    public async Task<IEnumerable<VehicleModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var vehicles = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleModels = vehicles.Adapt<IEnumerable<VehicleModel>>();

        return vehicleModels;
    }

    public async Task<VehicleModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = nameof(VehicleModel) + id;

        var cache = await distributedCache.GetDataFromCacheAsync<VehicleModel>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var vehicle = await repository.GetByIdAsync(id, cancellationToken);

        var vehicleModel = vehicle.Adapt<VehicleModel>();

        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(vehicleModel, cacheLifetime, key, cancellationToken);

        return vehicleModel;
    }

    public async Task<VehicleModel> AddAsync(VehicleModel vehicleModel, CancellationToken cancellationToken)
    {
        var vehicle = vehicleModel.Adapt<VehicleEntity>();

        await repository.AddAsync(vehicle, cancellationToken);

        var newVehicleModel = vehicle.Adapt<VehicleModel>();

        return newVehicleModel;
    }

    public async Task<VehicleModel> UpdateAsync(VehicleModel newVehicleModel, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(newVehicleModel.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.NotFound(nameof(VehicleEntity), newVehicleModel.Id));

        newVehicleModel.Adapt(vehicle);

        await repository.UpdateAsync(vehicle, cancellationToken);

        var vehicleToUpdate = vehicle.Adapt<VehicleModel>();

        var key = nameof(VehicleModel) + vehicleToUpdate.Id;
        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(vehicleToUpdate, cacheLifetime, key, cancellationToken);

        return vehicleToUpdate;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.NotFound(nameof(VehicleEntity), id));

        await repository.RemoveAsync(vehicle, cancellationToken);

        var key = nameof(VehicleModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);
    }
}