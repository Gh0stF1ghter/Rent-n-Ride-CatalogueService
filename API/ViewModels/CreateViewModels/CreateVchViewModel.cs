namespace BLL.ViewModels;

public record CreateVchViewModel(
    DateTime StartDate,
    DateTime EndDate,
    Guid VehicleId,
    Guid ClientId
    );