namespace BLL.Models;

public record CarModel(
    Guid Id,
    string Name,
    ManufacturerModel? Manufacturer,
    IEnumerable<VehicleModel> Vehicles
    );