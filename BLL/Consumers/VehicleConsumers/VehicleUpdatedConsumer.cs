using BLL.Models;
using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.VehicleEvents;
using Mapster;
using MassTransit;

namespace BLL.Consumers.VehicleConsumers;

public class VehicleUpdatedConsumer(IVehicleService service) : IConsumer<VehicleUpdated>
{
    public async Task Consume(ConsumeContext<VehicleUpdated> context)
    {
        var vehicleFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"vehicle {vehicleFromEvent.Id} consumed to update");

        var vehicleModel = vehicleFromEvent.Adapt<VehicleModel>();

        await service.UpdateAsync(vehicleModel, default);
    }
}