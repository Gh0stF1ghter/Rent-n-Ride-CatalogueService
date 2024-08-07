using API.ViewModels;
using API.ViewModels.ShortViewModels;
using API.ViewModels.UpdateViewModels;
using BLL.Models;
using BLL.Services.Interfaces;
using DAL.QueryParameters;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/vehicle")]
public class VehicleController(IVehicleService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllVehiclesInRange")]
    public async Task<IEnumerable<VehicleViewModel>> GetAll(
        [FromQuery] int page,
        [FromQuery] int pageSize,
        [FromQuery] VehicleParameters parameters,
        CancellationToken cancellationToken)
    {
        var vehicles = await service.GetRangeAsync(page, pageSize, cancellationToken, parameters);

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
    [Authorize("change:catalogue")]
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
    public async Task<VehicleViewModel> Update([FromRoute] Guid id, [FromBody] UpdateVehicleViewModel updateVehicleViewModel, CancellationToken cancellationToken)
    {
        var vehicleModel = updateVehicleViewModel.Adapt<VehicleModel>();
        vehicleModel.Id = id;

        var newVehicle = await service.UpdateAsync(vehicleModel, cancellationToken);

        var vehicleVM = newVehicle.Adapt<VehicleViewModel>();

        return vehicleVM;
    }

    [HttpDelete("{id}")]
    [Authorize("change:catalogue")]
    [ActionName("DeleteVehicleById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}