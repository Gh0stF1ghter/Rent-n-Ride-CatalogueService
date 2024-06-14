namespace BLL.Models;

public record VchModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    VehicleModel? Vehicle,
    ClientModel? Client
    );