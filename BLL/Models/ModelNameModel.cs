using DAL.Entities;

namespace DAL.Models;

public record ModelNameModel(
    Guid Id,
    string Name,
    Manufacturer? Manufacturer,
    IEnumerable<Vehicle> Vehicles
    );