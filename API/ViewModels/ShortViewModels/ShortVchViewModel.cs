namespace API.ViewModels;

public record ShortVchViewModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    VehicleViewModel? Vehicle,
    ClientViewModel? Client
    );