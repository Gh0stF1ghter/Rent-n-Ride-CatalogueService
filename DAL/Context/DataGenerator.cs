using Bogus;
using DAL.Entities;
using DAL.Enums;

namespace DAL.TestDataGenerator;

internal static class DataGenerator
{
    private const int CountOfGeneratedUnits = 5;

    public static readonly List<Client> Clients = [];
    public static readonly List<Manufacturer> Manufacturers = [];
    public static readonly List<ModelName> VehicleModels = [];
    public static readonly List<Vehicle> Vehicles = [];
    public static readonly List<VehicleClientHistory> VehicleClientHistories = [];

    public static void Init()
    {
        if (Manufacturers.Count > 0)
            return;

        AddManufacturerData();
        AddVehicleClientHistoryData();
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

        VehicleModels.AddRange(generatedModels);
    }

    private static void AddVehicleData(Guid modelId)
    {
        var vehicleFaker = GetVehicleFaker(modelId);

        var generatedVehicles = vehicleFaker.Generate(CountOfGeneratedUnits);

        Vehicles.AddRange(generatedVehicles);
    }

    private static void AddClientData(Guid vehicleId)
    {
        var clientFaker = GetClientFaker(vehicleId);

        var generatedClient = clientFaker.Generate();

        Clients.Add(generatedClient);
    }

    private static void AddVehicleClientHistoryData()
    {
        var vehicleClientHistoryFaker = GetVehicleClientHistoryFaker();

        var generatedVCH = vehicleClientHistoryFaker.Generate(CountOfGeneratedUnits);

        VehicleClientHistories.AddRange(generatedVCH);
    }

    private static Faker<Manufacturer> GetManufacturerFaker() =>
        new Faker<Manufacturer>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Manufacturer())
            .RuleFor(m => m.ModelNames, (_, m) =>
            {
                AddModelData(m.Id);
                return [];
            });

    private static Faker<ModelName> GetModelFaker(Guid manufacturerId) =>
        new Faker<ModelName>()
            .RuleFor(m => m.Id, _ => Guid.NewGuid())
            .RuleFor(m => m.Name, f => f.Vehicle.Model())
            .RuleFor(m => m.ManufacturerId, _ => manufacturerId)
            .RuleFor(m => m.Vehicles, (_, m) =>
            {
                AddVehicleData(m.Id);
                return [];
            });

    private static Faker<Vehicle> GetVehicleFaker(Guid modelId) =>
        new Faker<Vehicle>()
            .RuleFor(v => v.Id, _ => Guid.NewGuid())
            .RuleFor(v => v.PlateNumber, f => f.Vehicle.Vin())
            .RuleFor(v => v.Odo, f => f.Random.Number(0, 10000))
            .RuleFor(v => v.RentCost, f => f.Random.Double(100.0, 4000.9))
            .RuleFor(v => v.ModelId, _ => modelId)
            .RuleFor(v => v.VehicleType, f => f.PickRandom<VehicleType>())
            .RuleFor(v => v.VehicleState, f => f.PickRandom<VehicleState>())
            .RuleFor(v => v.FuelType, f => f.PickRandom<FuelType>())
            .RuleFor(v => v.Client, (_, e) =>
            {
                AddClientData(e.Id);
                return null;
            });

    private static Faker<Client> GetClientFaker(Guid vehicleId) =>
        new Faker<Client>()
            .RuleFor(c => c.Id, _ => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.VehicleId, _ => vehicleId);

    private static Faker<VehicleClientHistory> GetVehicleClientHistoryFaker() =>
        new Faker<VehicleClientHistory>()
            .RuleFor(vch => vch.Id, _ => Guid.NewGuid())
            .RuleFor(vch => vch.StartDate, f => f.Date.Past(refDate: DateTime.UtcNow))
            .RuleFor(vch => vch.EndDate, f => f.Date.Past(refDate: DateTime.UtcNow))
            .RuleFor(vch => vch.ClientId, f => f.PickRandom(Clients).Id)
            .RuleFor(vch => vch.VehicleId, f => f.PickRandom(Vehicles).Id);
}