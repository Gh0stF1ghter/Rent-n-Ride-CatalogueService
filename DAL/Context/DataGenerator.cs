using Bogus;
using DAL.Entities;
using DAL.Enums;

namespace DAL.Context;

internal static class DataGenerator
{
    private const int CountOfGeneratedUnits = 5;

    public static readonly List<ManufacturerEntity> Manufacturers = [];
    public static readonly List<CarModelEntity> CarModels = [];
    public static readonly List<VehicleEntity> Vehicles = [];

    public static void Init()
    {
        if (Manufacturers.Count > 0)
            return;

        AddManufacturerData();
    }

    private static void AddManufacturerData()
    {
        var manufacturerFaker = GetManufacturerFaker();

        var generatedManufacturers = manufacturerFaker.Generate(CountOfGeneratedUnits);

        Manufacturers.AddRange(generatedManufacturers);
    }

    private static void AddModelData(Guid manufacturerId)
    {
        var modelFaker = GetModelFaker(manufacturerId);

        var generatedModels = modelFaker.Generate(CountOfGeneratedUnits);

        CarModels.AddRange(generatedModels);
    }

    private static void AddVehicleData(Guid modelId)
    {
        var vehicleFaker = GetVehicleFaker(modelId);

        var generatedVehicles = vehicleFaker.Generate(CountOfGeneratedUnits);

        Vehicles.AddRange(generatedVehicles);
    }

    private static Faker<ManufacturerEntity> GetManufacturerFaker() =>
        new Faker<ManufacturerEntity>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Manufacturer())
            .RuleFor(m => m.CarModels, (_, m) =>
            {
                AddModelData(m.Id);
                return [];
            });

    private static Faker<CarModelEntity> GetModelFaker(Guid manufacturerId) =>
        new Faker<CarModelEntity>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Model())
            .RuleFor(m => m.ManufacturerId, _ => manufacturerId)
            .RuleFor(m => m.Vehicles, (_, m) =>
            {
                AddVehicleData(m.Id);
                return [];
            });

    private static Faker<VehicleEntity> GetVehicleFaker(Guid modelId) =>
        new Faker<VehicleEntity>()
            .RuleFor(v => v.Id, _ => Guid.NewGuid())
            .RuleFor(v => v.PlateNumber, f => f.Vehicle.Vin())
            .RuleFor(v => v.Odo, f => f.Random.Number(0, 10000))
            .RuleFor(v => v.RentCost, f => f.Random.Decimal(100, 4000))
            .RuleFor(v => v.IsRented, f => f.Random.Bool())
            .RuleFor(v => v.ModelId, _ => modelId)
            .RuleFor(v => v.VehicleType, f => f.PickRandom<VehicleType>())
            .RuleFor(v => v.VehicleState, f => f.PickRandom<VehicleState>())
            .RuleFor(v => v.FuelType, f => f.PickRandom<FuelType>());
}