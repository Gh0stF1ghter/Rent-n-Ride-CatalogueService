namespace API.ViewModels.CreateViewModels;

public record CreateVchViewModel(
    DateTime StartDate,
    DateTime EndDate,
    Guid VehicleId,
    Guid ClientId
    );