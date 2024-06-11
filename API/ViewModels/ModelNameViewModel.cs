namespace API.ViewModels;

public record ModelNameViewModel(
    Guid Id,
    string Name,
    ManufacturerViewModel? Manufacturer,
    IEnumerable<VehicleViewModel> Vehicles
    );