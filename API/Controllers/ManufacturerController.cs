using BLL.Services.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers;

[ApiController]
[Route("api/manufacturer")]
public class ManufacturerController(IManufacturerService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllManufacturersInRange")]
    [ProducesResponseType(typeof(IEnumerable<ManufacturerViewModel>), 200)]
    public async Task<IActionResult> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await service.GetRangeAsync(page, pageSize, cancellationToken);

        return Ok(manufacturers);
    }

    [HttpGet("{id}")]
    [ActionName("GetManufacturerById")]
    [ProducesResponseType(typeof(ManufacturerViewModel), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await service.GetByIdAsync(id, cancellationToken);

        return Ok(manufacturer);
    }

    [HttpPost]
    [ActionName("CreateManufacturer")]
    [ProducesResponseType(typeof(ManufacturerViewModel), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateManufacturerViewModel createManufacturerViewModel, CancellationToken cancellationToken)
    {
        var newManufacturer = await service.AddAsync(createManufacturerViewModel, cancellationToken);

        return CreatedAtAction("GetManufacturerById", new { id = newManufacturer.Id }, newManufacturer);
    }

    [HttpPut("{id}")]
    [ActionName("UpdateManufacturerById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateManufacturerViewModel updateManufacturerViewModel, CancellationToken cancellationToken)
    {
        await service.UpdateAsync(id, updateManufacturerViewModel, cancellationToken);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteManufacturerById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);

        return NoContent();
    }
}