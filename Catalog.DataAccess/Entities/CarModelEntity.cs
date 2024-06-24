namespace Catalog.DataAccess.Entities;

public class CarModelEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public Guid ManufacturerId { get; set; }
    public ManufacturerEntity? Manufacturer { get; set; }

    public IEnumerable<VehicleEntity>? Vehicles { get; set; }
}