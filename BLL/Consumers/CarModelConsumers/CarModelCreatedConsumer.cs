using BLL.Models;
using BLL.Services.Interfaces;
using EventBus.CatalogueServiceEvents.CarModelEvents;
using Mapster;
using MassTransit;

namespace BLL.Consumers.CarModelConsumers;

public class CarModelCreatedConsumer(ICarModelService service) : IConsumer<CarModelCreated>
{
    public async Task Consume(ConsumeContext<CarModelCreated> context)
    {
        var carModelFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"car model {carModelFromEvent.Name} consumed to create");

        var carModel = carModelFromEvent.Adapt<CarModel>();

        await service.AddAsync(carModel, default);
    }
}