using DAL.Entities;

namespace BLL.ViewModels;

public record ManufacturerViewModel(
    Guid Id,
    string Name,
    IEnumerable<ModelName> ModelNames
    );