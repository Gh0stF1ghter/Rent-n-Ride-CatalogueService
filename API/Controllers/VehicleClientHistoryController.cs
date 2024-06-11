using API.ViewModels;
using API.ViewModels.ShortViewModels;
using BLL.Models;
using BLL.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/history-of-use")]
public class VehicleClientHistoryController(IVehicleClientHistoryService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAlVehicleClientHistoriesInRange")]
    public async Task<IEnumerable<VchViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var vehicleClientHistories = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var vehicleClientHistoriesVMs = vehicleClientHistories.Adapt<IEnumerable<VchViewModel>>();

        return vehicleClientHistoriesVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetVehicleClientHistoryById")]
    public async Task<VchViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var vehicleClientHistory = await service.GetByIdAsync(id, cancellationToken);

        var vehicleClientHistoryVM = vehicleClientHistory.Adapt<VchViewModel>();

        return vehicleClientHistoryVM;
    }

    [HttpPost]
    [ActionName("CreateVehicleClientHistory")]
    public async Task<VchViewModel> Create([FromBody] ShortVchViewModel createVehicleClientHistoryViewModel, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryModel = createVehicleClientHistoryViewModel.Adapt<VchModel>();

        var newVehicleClientHistory = await service.AddAsync(vehicleClientHistoryModel, cancellationToken);

        var vehicleClientHistoryVM = newVehicleClientHistory.Adapt<VchViewModel>();

        return vehicleClientHistoryVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateModelNameById")]
    public async Task<VchViewModel> Update([FromRoute] Guid id, [FromBody] ShortVchViewModel updateModelNameViewModel, CancellationToken cancellationToken)
    {
        var vehicleClientHistoryModel = updateModelNameViewModel.Adapt<VchModel>();

        vehicleClientHistoryModel.Id = id;

        var newVehicleClientHistory = await service.UpdateAsync(vehicleClientHistoryModel, cancellationToken);

        var vehicleClientHistoryVM = newVehicleClientHistory.Adapt<VchViewModel>();

        return vehicleClientHistoryVM;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteVehicleClientHistoryById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}