using API.ViewModels;
using API.ViewModels.CreateViewModels;
using BLL.Services.Interfaces;
using DAL.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/model")]
public class ModelNameController(IModelNameService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllModelNamesInRange")]
    public async Task<IEnumerable<ModelNameViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var modelNames = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var modelNamesVMs = modelNames.Adapt<IEnumerable<ModelNameViewModel>>();

        return modelNamesVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetModelNameById")]
    public async Task<ModelNameViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var modelName = await service.GetByIdAsync(id, cancellationToken);

        var modelNameVM = modelName.Adapt<ModelNameViewModel>();

        return modelNameVM;
    }

    [HttpPost]
    [ActionName("CreateModelName")]
    public async Task<ModelNameViewModel> Create([FromBody] CreateModelNameViewModel createModelNameViewModel, CancellationToken cancellationToken)
    {
        var modelNameModel = createModelNameViewModel.Adapt<ModelNameModel>();

        var newModelName = await service.AddAsync(modelNameModel, cancellationToken);

        var modelNameVM = newModelName.Adapt<ModelNameViewModel>();

        return modelNameVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateModelNameById")]
    public async Task<ModelNameViewModel> Update([FromRoute] Guid id, [FromBody] CreateModelNameViewModel updateModelNameViewModel, CancellationToken cancellationToken)
    {
        var modelNameModel = updateModelNameViewModel.Adapt<ModelNameModel>();
        modelNameModel.Id = id;

        var newModelName = await service.UpdateAsync(modelNameModel, cancellationToken);

        var modelNameVM = newModelName.Adapt<ModelNameViewModel>();

        return modelNameVM;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteModelNameById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}