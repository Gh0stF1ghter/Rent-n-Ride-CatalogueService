namespace BLL.ViewModels;

public record CreateVchViewModel(
    DateTime UseTime,
    Guid VehicleId,
    Guid ClientId
    );