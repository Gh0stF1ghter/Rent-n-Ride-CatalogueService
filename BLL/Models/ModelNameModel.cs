using DAL.Entities;

namespace DAL.Models;

public record ModelNameModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Manufacturer? Manufacturer { get; set; }
    public IEnumerable<Vehicle>? Vehicles { get; set; }
}