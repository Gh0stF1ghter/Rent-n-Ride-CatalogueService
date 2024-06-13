using API.ViewModels;
using API.ViewModels.ShortViewModels;
using BLL.Models;
using BLL.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/manufacturer")]
public class ManufacturerController(IManufacturerService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllManufacturersInRange")]
    public async Task<IEnumerable<ManufacturerViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var manufacturers = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var manufacturersVMs = manufacturers.Adapt<IEnumerable<ManufacturerViewModel>>();

        return manufacturersVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetManufacturerById")]
    public async Task<ManufacturerViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var manufacturer = await service.GetByIdAsync(id, cancellationToken);

        var manufacturerVM = manufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerVM;
    }

    [HttpPost]
    [ActionName("CreateManufacturer")]
    public async Task<ManufacturerViewModel> Create([FromBody] ShortManufacturerViewModel createManufacturerViewModel, CancellationToken cancellationToken)
    {
        var manufacturerModel = createManufacturerViewModel.Adapt<ManufacturerModel>();

        var newManufacturer = await service.AddAsync(manufacturerModel, cancellationToken);

        var manufacturerVM = newManufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateManufacturerById")]
    public async Task<ManufacturerViewModel> Update([FromRoute] Guid id, [FromBody] ShortManufacturerViewModel updateManufacturerViewModel, CancellationToken cancellationToken)
    {
        var manufacturerModel = updateManufacturerViewModel.Adapt<ManufacturerModel>();
        manufacturerModel.Id = id;

        var newManufacturer = await service.UpdateAsync(manufacturerModel, cancellationToken);

        var manufacturerVM = newManufacturer.Adapt<ManufacturerViewModel>();

        return manufacturerVM;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteManufacturerById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}