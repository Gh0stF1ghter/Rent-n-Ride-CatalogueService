using BLL.Services.Interfaces;
using BLL.ViewModels;
using DAL.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController(IClientService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllClientsInRange")]
    [ProducesResponseType(typeof(IEnumerable<ClientViewModel>), 200)]
    public async Task<IActionResult> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var clients = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var clientsVMs = clients.Adapt<ClientViewModel>();

        return Ok(clientsVMs);
    }

    [HttpGet("{id}")]
    [ActionName("GetClientById")]
    [ProducesResponseType(typeof(ClientViewModel), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var client = await service.GetByIdAsync(id, cancellationToken);

        var clientVM = client.Adapt<ClientViewModel>();

        return Ok(clientVM);
    }

    [HttpPost]
    [ActionName("CreateClient")]
    [ProducesResponseType(typeof(ClientViewModel), (int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateClientViewModel createClientViewModel, CancellationToken cancellationToken)
    {
        var createClientModel = createClientViewModel.Adapt<ClientModel>();

        var newClient = await service.AddAsync(createClientModel, cancellationToken);

        return CreatedAtAction("GetClientById", new { id = newClient.Id }, newClient);
    }

    [HttpPut("{id}")]
    [ActionName("UpdateClientById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CreateClientViewModel updateClientViewModel, CancellationToken cancellationToken)
    {
        await service.UpdateAsync(id, updateClientViewModel, cancellationToken);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteClientById")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);

        return NoContent();
    }
}