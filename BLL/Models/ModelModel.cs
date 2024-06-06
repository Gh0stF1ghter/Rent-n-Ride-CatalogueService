using DAL.Entities;

namespace DAL.Models;
public record ModelModel(
    Guid Id,
    string Name,
    Manufacturer Manufacturer,
    IEnumerable<Vehicle> Vehicles
    );
