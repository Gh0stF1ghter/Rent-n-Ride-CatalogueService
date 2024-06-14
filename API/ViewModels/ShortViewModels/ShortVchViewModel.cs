namespace API.ViewModels.ShortViewModels;

public record ShortVchViewModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    Guid VehicleId,
    Guid ClientId
    );