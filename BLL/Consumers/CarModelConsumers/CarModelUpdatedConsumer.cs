using BLL.Models;
using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.CarModelEvents;
using Mapster;
using MassTransit;

namespace BLL.Consumers.CarModelConsumers;

public class CarModelUpdatedConsumer(ICarModelService service) : IConsumer<CarModelUpdated>
{
    public async Task Consume(ConsumeContext<CarModelUpdated> context)
    {
        var carModelFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"car model {carModelFromEvent.Name} consumed to update");

        var carModel = carModelFromEvent.Adapt<CarModel>();

        await service.UpdateAsync(carModel, default);
    }
}