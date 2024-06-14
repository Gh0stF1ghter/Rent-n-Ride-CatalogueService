using DAL.Enums;

namespace API.ViewModels.ShortViewModels;

public record ShortVehicleViewModel(
    Guid ModelId,
    string PlateNumber,
    decimal RentCost,
    int Odo,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType
    );