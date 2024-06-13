namespace API.ViewModels;

public record VehicleClientHistoryViewModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    VehicleViewModel? Vehicle,
    ClientViewModel? Client
    );