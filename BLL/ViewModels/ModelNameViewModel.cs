using DAL.Entities;

namespace BLL.ViewModels;

public record ModelNameViewModel(
    Guid Id,
    string Name,
    Manufacturer? Manufacturer,
    IEnumerable<Vehicle> Vehicles
    );