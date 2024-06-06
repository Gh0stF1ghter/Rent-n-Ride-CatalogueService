using DAL.Entities;

namespace DAL.Models;

public record ManufacturerModel(Guid Id,
    string Name,
    IEnumerable<ModelName> ModelNames
    );