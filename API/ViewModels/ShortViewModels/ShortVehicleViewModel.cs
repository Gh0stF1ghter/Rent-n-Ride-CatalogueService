using DAL.Enums;

namespace API.ViewModels.ShortViewModels;

public record ShortVehicleViewModel(
    Guid ModelId,
    string PlateNumber,
    decimal RentCost,
    int Odo,
    VehicleType VehicleType = VehicleType.None,
    VehicleState VehicleState = VehicleState.None,
    FuelType FuelType = FuelType.None
    );