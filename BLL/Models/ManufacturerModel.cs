using DAL.Entities;

namespace BLL.Models;

public record ManufacturerModel(Guid Id,
    string Name,
    IEnumerable<ModelName> ModelNames
    );