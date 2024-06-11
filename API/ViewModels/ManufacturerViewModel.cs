namespace API.ViewModels;

public record ManufacturerViewModel(
    Guid Id,
    string Name,
    IEnumerable<ModelNameViewModel> ModelNames
    );