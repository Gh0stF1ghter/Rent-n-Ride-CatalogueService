using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.CarModelEvents;
using MassTransit;

namespace BLL.Consumers.CarModelConsumers;

public class CarModelDeletedConsumer(ICarModelService service) : IConsumer<CarModelDeleted>
{
    public async Task Consume(ConsumeContext<CarModelDeleted> context)
    {
        var carModelId = context.Message.Id;

        await Console.Out.WriteLineAsync($"car model {carModelId} consumed to delete");

        await service.DeleteAsync(carModelId, default);
    }
}