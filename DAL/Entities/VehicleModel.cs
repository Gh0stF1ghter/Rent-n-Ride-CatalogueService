namespace DAL.Entities;

public class VehicleModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public Guid ManufacturerId { get; set; }
    public Manufacturer? Manufacturer { get; set; }

    public IEnumerable<Vehicle> Vehicles { get; set; } = [];
}