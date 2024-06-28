using API.ViewModels;
using API.ViewModels.ShortViewModels;
using BLL.Models;
using BLL.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/model")]
public class CarModelController(ICarModelService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllModelNamesInRange")]
    public async Task<IEnumerable<CarModelViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var modelNames = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var modelNamesVMs = modelNames.Adapt<IEnumerable<CarModelViewModel>>();

        return modelNamesVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetModelNameById")]
    public async Task<CarModelViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var modelName = await service.GetByIdAsync(id, cancellationToken);

        var modelNameVM = modelName.Adapt<CarModelViewModel>();

        return modelNameVM;
    }

    [HttpPost]
    [Authorize("change:catalogue")]
    [ActionName("CreateModelName")]
    public async Task<CarModelViewModel> Create([FromBody] ShortCarModelViewModel createModelNameViewModel, CancellationToken cancellationToken)
    {
        var modelNameModel = createModelNameViewModel.Adapt<CarModel>();

        var newModelName = await service.AddAsync(modelNameModel, cancellationToken);

        var modelNameVM = newModelName.Adapt<CarModelViewModel>();

        return modelNameVM;
    }

    [HttpPut("{id}")]
    [Authorize("change:catalogue")]
    [ActionName("UpdateModelNameById")]
    public async Task<CarModelViewModel> Update([FromRoute] Guid id, [FromBody] ShortCarModelViewModel updateModelNameViewModel, CancellationToken cancellationToken)
    {
        var modelNameModel = updateModelNameViewModel.Adapt<CarModel>();
        modelNameModel.Id = id;

        var newModelName = await service.UpdateAsync(modelNameModel, cancellationToken);

        var modelNameVM = newModelName.Adapt<CarModelViewModel>();

        return modelNameVM;
    }

    [HttpDelete("{id}")]
    [Authorize("change:catalogue")]
    [ActionName("DeleteModelNameById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}