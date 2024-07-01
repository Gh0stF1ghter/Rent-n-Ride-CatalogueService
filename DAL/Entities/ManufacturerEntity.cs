namespace DAL.Entities;

public class ManufacturerEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public IEnumerable<CarModelEntity>? CarModels { get; set; }
}