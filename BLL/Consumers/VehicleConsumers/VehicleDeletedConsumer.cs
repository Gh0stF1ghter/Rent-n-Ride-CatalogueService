using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.VehicleEvents;
using MassTransit;

namespace BLL.Consumers.VehicleConsumers;

public class VehicleDeletedConsumer(IVehicleService service) : IConsumer<VehicleDeleted>
{
    public async Task Consume(ConsumeContext<VehicleDeleted> context)
    {
        var vehicleId = context.Message.Id;

        await Console.Out.WriteLineAsync($"vehicle {vehicleId} consumed to delete");

        await service.DeleteAsync(vehicleId, default);
    }
}