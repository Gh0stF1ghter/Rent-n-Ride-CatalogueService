using BLL.Services.Interfaces;
using DAL.Mappers;
using DAL.Models;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementations;

public class VehicleClientHistoryService(IVehicleClientHistoryRepository repository) : IVehicleClientHistoryService
{
    public async Task<IEnumerable<VchModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var vehicleClientHistories = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleClientHistoryModels = new List<VchModel>();

        foreach (var vehicleClientHistory in vehicleClientHistories)
        {
            var vehicleClientHistoryModel = VchMapper.Map(vehicleClientHistory);

            vehicleClientHistoryModels.Add(vehicleClientHistoryModel);
        }

        return vehicleClientHistoryModels;
    }

    public async Task<VchModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var vch = await repository.GetByIdAsync(id, cancellationToken);

        var vchModel = VchMapper.Map(vch);

        return vchModel;
    }

    public async Task<VchModel> AddAsync(VchModel vchModel, CancellationToken cancellationToken)
    {
        var vch = VchMapper.Map(vchModel);

        await repository.AddAsync(vch, cancellationToken);

        var newVchModel = VchMapper.Map(vch);

        return newVchModel;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelName = await repository.GetByIdAsync(id, cancellationToken);

        await repository.RemoveAsync(modelName, cancellationToken);
    }
}