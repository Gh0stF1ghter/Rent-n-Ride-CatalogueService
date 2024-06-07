using BLL.Services.Interfaces;
using DAL.Mappers;
using DAL.Models;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Implementations;

public class VehicleService(IVehicleRepository repository) : IVehicleService
{
    public async Task<IEnumerable<VehicleModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var vehicles = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleModels = new List<VehicleModel>();

        foreach (var modelName in vehicles)
        {
            var vehicleModel = VehicleMapper.Map(modelName);

            vehicleModels.Add(vehicleModel);
        }

        return vehicleModels;
    }

    public async Task<VehicleModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, false, cancellationToken);

        var vehicleModel = VehicleMapper.Map(vehicle);

        return vehicleModel;
    }

    public async Task<VehicleModel> AddAsync(VehicleModel vehicleModel, CancellationToken cancellationToken)
    {
        var vehicle = VehicleMapper.Map(vehicleModel);

        await repository.AddAsync(vehicle, cancellationToken);

        var newVehicleModel = VehicleMapper.Map(vehicle);

        return newVehicleModel;
    }

    public async Task UpdateAsync(Guid id, VehicleModel newVehicleModel, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, true, cancellationToken);

        vehicle = VehicleMapper.Map(newVehicleModel);

        await repository.UpdateAsync(vehicle, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, true, cancellationToken);

        repository.RemoveAsync(vehicle, cancellationToken);
    }
}