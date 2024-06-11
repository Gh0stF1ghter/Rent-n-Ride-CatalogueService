namespace BLL.Models;

public class ManufacturerModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public IEnumerable<ModelNameModel>? ModelNames { get; set; }
}