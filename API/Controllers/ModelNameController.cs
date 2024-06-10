using BLL.Services.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers;

[ApiController]
[Route("api/model")]
public class ModelNameController(IModelNameService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllModelNamesInRange")]
    [ProducesResponseType(typeof(IEnumerable<ModelNameViewModel>), 200)]
    public async Task<IActionResult> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var modelNames = await service.GetRangeAsync(page, pageSize, cancellationToken);

        return Ok(modelNames);
    }

    [HttpGet("{id}")]
    [ActionName("GetModelNameById")]
    [ProducesResponseType(typeof(ModelNameViewModel), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var modelName = await service.GetByIdAsync(id, cancellationToken);

        return Ok(modelName);
    }

    [HttpPost]
    [ActionName("CreateModelName")]
    [ProducesResponseType(typeof(ModelNameViewModel), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateModelNameViewModel createModelNameViewModel, CancellationToken cancellationToken)
    {
        var newModelName = await service.AddAsync(createModelNameViewModel, cancellationToken);

        return CreatedAtAction("GetModelNameById", new { id = newModelName.Id }, newModelName);
    }

    [HttpPut("{id}")]
    [ActionName("UpdateModelNameById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateModelNameViewModel updateModelNameViewModel, CancellationToken cancellationToken)
    {
        await service.UpdateAsync(id, updateModelNameViewModel, cancellationToken);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteModelNameById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);

        return NoContent();
    }
}