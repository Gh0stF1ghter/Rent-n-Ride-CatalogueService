namespace BLL.ViewModels;

public record VchViewModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    VehicleViewModel? Vehicle,
    ClientViewModel? Client
    );