using DAL.Entities;

namespace DAL.Models;

public record ManufacturerModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public IEnumerable<ModelName>? ModelNames { get; set; }
}