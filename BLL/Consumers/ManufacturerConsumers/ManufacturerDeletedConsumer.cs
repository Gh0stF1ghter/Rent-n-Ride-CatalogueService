using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.ManufacturerEvents;
using MassTransit;

namespace BLL.Consumers.ManufacturerConsumers;

public class ManufacturerDeletedConsumer(IManufacturerService service) : IConsumer<ManufacturerDeleted>
{
    public async Task Consume(ConsumeContext<ManufacturerDeleted> context)
    {
        var manufacturerId = context.Message.Id;

        await Console.Out.WriteLineAsync($"manufacturer {manufacturerId} consumed to delete");

        await service.DeleteAsync(manufacturerId, default);
    }
}