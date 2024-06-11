namespace API.ViewModels;

public record ShortVchViewModel(
    DateTime StartDate,
    DateTime EndDate,
    Guid VehicleId,
    Guid ClientId
    );