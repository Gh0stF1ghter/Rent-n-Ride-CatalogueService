using Bogus;
using DAL.Entities;
using DAL.Enums;

namespace Tests.DataGeneration;

internal static class DataGenerator
{
    public static List<Manufacturer> AddManufacturerData(int count)
    {
        var manufacturerFaker = GetManufacturerFaker();

        return manufacturerFaker.Generate(count);
    }

    public static List<ModelName> AddModelData(int count)
    {
        var modelFaker = GetModelFaker();

        return modelFaker.Generate(count);
    }

    public static List<Vehicle> AddVehicleData(int count)
    {
        var vehicleFaker = GetVehicleFaker();

        return vehicleFaker.Generate(count);
    }

    public static List<Client> AddClientData(int count)
    {
        var clientFaker = GetClientFaker();

        return clientFaker.Generate(count);
    }

    public static List<VehicleClientHistory> AddVehicleClientHistoryData(int count)
    {
        var vehicleClientHistoryFaker = GetVehicleClientHistoryFaker();

        return vehicleClientHistoryFaker.Generate(count);
    }

    private static Faker<Manufacturer> GetManufacturerFaker() =>
        new Faker<Manufacturer>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Manufacturer());

    private static Faker<ModelName> GetModelFaker() =>
        new Faker<ModelName>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Model())
            .RuleFor(m => m.ManufacturerId, _ => Guid.NewGuid());

    private static Faker<Vehicle> GetVehicleFaker() =>
        new Faker<Vehicle>()
            .RuleFor(v => v.Id, _ => Guid.NewGuid())
            .RuleFor(v => v.PlateNumber, f => f.Vehicle.Vin())
            .RuleFor(v => v.Odo, f => f.Random.Number(0, 10000))
            .RuleFor(v => v.RentCost, f => f.Random.Double(100.0, 4000.9))
            .RuleFor(v => v.ModelId, _ => Guid.NewGuid())
            .RuleFor(v => v.VehicleType, f => f.PickRandom<VehicleType>())
            .RuleFor(v => v.VehicleState, f => f.PickRandom<VehicleState>())
            .RuleFor(v => v.FuelType, f => f.PickRandom<FuelType>());

    private static Faker<Client> GetClientFaker() =>
        new Faker<Client>()
            .RuleFor(c => c.Id, _ => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber());

    private static Faker<VehicleClientHistory> GetVehicleClientHistoryFaker() =>
        new Faker<VehicleClientHistory>()
            .RuleFor(vch => vch.Id, _ => Guid.NewGuid())
            .RuleFor(vch => vch.StartDate, f => f.Date.Past(refDate: DateTime.UtcNow))
            .RuleFor(vch => vch.EndDate, f => f.Date.Past(refDate: DateTime.UtcNow));
}