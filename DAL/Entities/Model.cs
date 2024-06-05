namespace DAL.Entities;

public class Model
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public Manufacturer? Manufacturer { get; set; }
}