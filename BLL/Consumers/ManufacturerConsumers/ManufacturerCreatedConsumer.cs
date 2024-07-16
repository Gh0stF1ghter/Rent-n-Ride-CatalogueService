using BLL.Models;
using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.ManufacturerEvents;
using Mapster;
using MassTransit;

namespace BLL.Consumers.ManufacturerConsumers;

public class ManufacturerCreatedConsumer(IManufacturerService service) : IConsumer<ManufacturerCreated>
{
    public async Task Consume(ConsumeContext<ManufacturerCreated> context)
    {
        var manufacturerFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"manufacturer {manufacturerFromEvent.Name} consumed to create");

        var manufacturer = manufacturerFromEvent.Adapt<ManufacturerModel>();

        await service.AddAsync(manufacturer, default);
    }
}