using API.ViewModels;
using API.ViewModels.ShortViewModels;
using BLL.Models;
using BLL.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
[ApiController]
[Route("api/vehicle")]
public class VehicleController(IVehicleService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllVehiclesInRange")]
    public async Task<IEnumerable<VehicleViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var vehicles = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var vehiclesVMs = vehicles.Adapt<IEnumerable<VehicleViewModel>>();

        return vehiclesVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetVehicleById")]
    public async Task<VehicleViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var vehicle = await service.GetByIdAsync(id, cancellationToken);

        var vehicleVM = vehicle.Adapt<VehicleViewModel>();

        return vehicleVM;
    }

    [HttpPost]
    [ActionName("CreateVehicle")]
    public async Task<VehicleViewModel> Create([FromBody] ShortVehicleViewModel createClientViewModel, CancellationToken cancellationToken)
    {
        var createVehicleModel = createClientViewModel.Adapt<VehicleModel>();

        var newVehicle = await service.AddAsync(createVehicleModel, cancellationToken);

        var vehicleVM = newVehicle.Adapt<VehicleViewModel>();

        return vehicleVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateVehicleById")]
    public async Task<VehicleViewModel> Update([FromRoute] Guid id, [FromBody] ShortVehicleViewModel updateVehicleViewModel, CancellationToken cancellationToken)
    {
        var vehicleModel = updateVehicleViewModel.Adapt<VehicleModel>();
        vehicleModel.Id = id;

        var newVehicle = await service.UpdateAsync(vehicleModel, cancellationToken);

        var vehicleVM = newVehicle.Adapt<VehicleViewModel>();

        return vehicleVM;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteVehicleById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}