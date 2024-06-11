using DAL.Enums;

namespace API.ViewModels;

public record ShortVehicleViewModel(
    Guid ModelId,
    string PlateNumber,
    decimal RentCost,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    int Odo
    );