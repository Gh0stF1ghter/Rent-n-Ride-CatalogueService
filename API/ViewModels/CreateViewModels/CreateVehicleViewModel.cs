using DAL.Enums;

namespace BLL.ViewModels;

public record CreateVehicleViewModel(
    Guid ModelId,
    string PlateNumber,
    decimal RentCost,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    int Odo
    );