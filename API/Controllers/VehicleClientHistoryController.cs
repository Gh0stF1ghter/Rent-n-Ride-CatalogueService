using BLL.Services.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers;

[ApiController]
[Route("api/history-of-use")]
public class VehicleClientHistoryController(IVehicleClientHistoryService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAlVehicleClientHistoriesInRange")]
    [ProducesResponseType(typeof(IEnumerable<VchViewModel>), 200)]
    public async Task<IActionResult> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var vehicleClientHistories = await service.GetRangeAsync(page, pageSize, cancellationToken);

        return Ok(vehicleClientHistories);
    }

    [HttpGet("{id}")]
    [ActionName("GetVehicleClientHistoryById")]
    [ProducesResponseType(typeof(VchViewModel), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var vehicleClientHistory = await service.GetByIdAsync(id, cancellationToken);

        return Ok(vehicleClientHistory);
    }

    [HttpPost]
    [ActionName("CreateVehicleClientHistory")]
    [ProducesResponseType(typeof(VchViewModel), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateVchViewModel createVehicleClientHistoryViewModel, CancellationToken cancellationToken)
    {
        var newVehicleClientHistory = await service.AddAsync(createVehicleClientHistoryViewModel, cancellationToken);

        return CreatedAtAction("GetVehicleClientHistoryById", new { id = newVehicleClientHistory.Id }, newVehicleClientHistory);
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteVehicleClientHistoryById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);

        return NoContent();
    }
}