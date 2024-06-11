namespace BLL.Models;

public record ModelNameModel(
    Guid Id,
    string Name,
    ManufacturerModel? Manufacturer,
    IEnumerable<VehicleModel> Vehicles
    );