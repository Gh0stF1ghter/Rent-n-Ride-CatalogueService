using DAL.Entities;

namespace BLL.ViewModels;
public record VchViewModel(
    Guid Id,
    DateTime UseTime,
    VehicleViewModel? Vehicle,
    ClientViewModel? Client
    );