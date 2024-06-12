namespace BLL.Models;

public record ManufacturerModel(Guid Id,
    string Name,
    IEnumerable<CarModel> ModelNames
    );