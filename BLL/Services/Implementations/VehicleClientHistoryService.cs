using BLL.Models;
using BLL.Services.Interfaces;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class VehicleClientHistoryService(IVehicleClientHistoryRepository repository) : IVehicleClientHistoryService
{
    public async Task<IEnumerable<VehicleClientHistoryModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var vehicleClientHistories = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleClientHistoryModels = vehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryModel>>();

        return vehicleClientHistoryModels;
    }

    public async Task<VehicleClientHistoryModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var vch = await repository.GetByIdAsync(id, cancellationToken);

        var vchModel = vch.Adapt<VehicleClientHistoryModel>();

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
        var newVchModel = await repository.GetByIdAsync(vchModel.Id, cancellationToken);

        vchModel.Adapt(newVchModel);

        await repository.UpdateAsync(newVchModel, cancellationToken);

        var vchModelToReturn = vchModel.Adapt<VehicleClientHistoryModel>();

        return vchModelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, cancellationToken);

        await repository.RemoveAsync(modelName, cancellationToken);
    }
}