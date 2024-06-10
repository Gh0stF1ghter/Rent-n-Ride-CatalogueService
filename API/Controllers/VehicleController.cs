using BLL.Services.Interfaces;
using BLL.ViewModels;
using DAL.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers;

[ApiController]
[Route("api/vehicle")]
public class VehicleController(IVehicleService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllVehiclesInRange")]
    [ProducesResponseType(typeof(IEnumerable<VehicleViewModel>), 200)]
    public async Task<IActionResult> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var clients = await service.GetRangeAsync(page, pageSize, cancellationToken);

        return Ok(clients);
    }

    [HttpGet("{id}")]
    [ActionName("GetVehicleById")]
    [ProducesResponseType(typeof(VehicleViewModel), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var client = await service.GetByIdAsync(id, cancellationToken);

        return Ok(client);
    }

    [HttpPost]
    [ActionName("CreateVehicle")]
    [ProducesResponseType(typeof(VehicleViewModel), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateVehicleViewModel createClientViewModel, CancellationToken cancellationToken)
    {
        var createClientModel = createClientViewModel.Adapt<VehicleModel>();

        var newClient = await service.AddAsync(createClientModel, cancellationToken);

        var clientVM = newClient.Adapt<VehicleViewModel>();

        return CreatedAtAction("GetVehicleById", new { id = clientVM.Id }, clientVM);
    }

    [HttpPut("{id}")]
    [ActionName("UpdateVehicleById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateVehicleViewModel updateVehicleViewModel, CancellationToken cancellationToken)
    {
        var clientModel = updateVehicleViewModel.Adapt<VehicleModel>();

        id.Adapt(clientModel);

        var newClient = await service.UpdateAsync(clientModel, cancellationToken);

        var clientVM = newClient.Adapt<VehicleViewModel>();

        return CreatedAtAction("GetClientById", new { id = clientVM.Id }, clientVM);
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteVehicleById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);

        return NoContent();
    }
}