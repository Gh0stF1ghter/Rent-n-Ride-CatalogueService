using BLL.Models;
using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.ManufacturerEvents;
using Mapster;
using MassTransit;

namespace BLL.Consumers.ManufacturerConsumers;

public class ManufacturerUpdatedConsumer(IManufacturerService service) : IConsumer<ManufacturerUpdated>
{
    public async Task Consume(ConsumeContext<ManufacturerUpdated> context)
    {
        var manufacturerFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"manufacturer {manufacturerFromEvent.Name} consumed to update");

        var manufacturerModel = manufacturerFromEvent.Adapt<ManufacturerModel>();

        await service.UpdateAsync(manufacturerModel, default);
    }
}