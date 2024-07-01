using Bogus;
using DAL.Entities;
using DAL.Enums;

namespace Tests.DataGeneration;

internal static class DataGenerator
{
    public static List<ManufacturerEntity> AddManufacturerData(int count)
    {
        var manufacturerFaker = GetManufacturerFaker();

        return manufacturerFaker.Generate(count);
    }

    public static List<CarModelEntity> AddModelData(int count)
    {
        var modelFaker = GetModelFaker();

        return modelFaker.Generate(count);
    }

    public static List<VehicleEntity> AddVehicleData(int count)
    {
        var vehicleFaker = GetVehicleFaker();

        return vehicleFaker.Generate(count);
    }
    private static Faker<ManufacturerEntity> GetManufacturerFaker() =>
        new Faker<ManufacturerEntity>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Manufacturer());

    private static Faker<CarModelEntity> GetModelFaker() =>
        new Faker<CarModelEntity>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Model())
            .RuleFor(m => m.ManufacturerId, _ => Guid.NewGuid());

    private static Faker<VehicleEntity> GetVehicleFaker() =>
        new Faker<VehicleEntity>()
            .RuleFor(v => v.Id, _ => Guid.NewGuid())
            .RuleFor(v => v.PlateNumber, f => f.Vehicle.Vin())
            .RuleFor(v => v.Odo, f => f.Random.Number(0, 10000))
            .RuleFor(v => v.RentCost, f => f.Random.Double(100.0, 4000.9))
            .RuleFor(v => v.ModelId, _ => Guid.NewGuid())
            .RuleFor(v => v.VehicleType, f => f.PickRandom<VehicleType>())
            .RuleFor(v => v.VehicleState, f => f.PickRandom<VehicleState>())
            .RuleFor(v => v.FuelType, f => f.PickRandom<FuelType>());
}