using DAL.Entities;

namespace BLL.Models;

public record ModelNameModel(
    Guid Id,
    string Name,
    Manufacturer? Manufacturer,
    IEnumerable<Vehicle> Vehicles
    );