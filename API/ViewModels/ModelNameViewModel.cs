using DAL.Entities;

namespace BLL.ViewModels;

public record ModelNameViewModel(
    Guid Id,
    string Name,
    ManufacturerViewModel? Manufacturer,
    IEnumerable<VehicleViewModel> Vehicles
    );