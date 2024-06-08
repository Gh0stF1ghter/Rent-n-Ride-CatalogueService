using BLL.Services.Interfaces;
using BLL.ViewModels;
using DAL.Entities;
using DAL.Models;
using DAL.Repositories.Interfaces;
using Mapster;

namespace BLL.Services.Implementations;

public class VehicleService(IVehicleRepository repository) : IVehicleService
{
    public async Task<IEnumerable<VehicleViewModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var vehicles = await repository.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleModels = vehicles.Adapt<IEnumerable<VehicleViewModel>>();

        return vehicleModels;
    }

    public async Task<VehicleViewModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, false, cancellationToken);

        var vehicleModel = vehicle.Adapt<VehicleViewModel>();

        return vehicleModel;
    }

    public async Task<VehicleViewModel> AddAsync(CreateVehicleViewModel vehicleModel, CancellationToken cancellationToken)
    {
        var vehicle = vehicleModel.Adapt<Vehicle>();

        await repository.AddAsync(vehicle, cancellationToken);

        var newVehicleModel = vehicle.Adapt<VehicleViewModel>();

        return newVehicleModel;
    }

    public async Task UpdateAsync(Guid id, CreateVehicleViewModel newVehicleModel, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, true, cancellationToken);

        newVehicleModel.Adapt(vehicle);

        await repository.UpdateAsync(vehicle, cancellationToken);
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await repository.GetByIdAsync(id, true, cancellationToken);

        await repository.RemoveAsync(vehicle, cancellationToken);
    }
}