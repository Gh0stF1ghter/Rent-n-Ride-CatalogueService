namespace API.ViewModels.ShortViewModels;

public record ShortVchViewModel(
    DateTime StartDate,
    DateTime EndDate,
    Guid VehicleId,
    Guid ClientId
    );