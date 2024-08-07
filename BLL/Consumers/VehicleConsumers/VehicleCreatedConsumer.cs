using BLL.Models;
using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.VehicleEvents;
using Mapster;
using MassTransit;

namespace BLL.Consumers.VehicleConsumers;

public class VehicleCreatedConsumer(IVehicleService service) : IConsumer<VehicleCreated>
{
    public async Task Consume(ConsumeContext<VehicleCreated> context)
    {
        var vehicleFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"vehicle {vehicleFromEvent.PlateNumber} consumed to create");

        var vehicle = vehicleFromEvent.Adapt<VehicleModel>();

        await service.AddAsync(vehicle, default);
    }
}