using DAL.Enums;

namespace API.ViewModels.CreateViewModels;

public record CreateVehicleViewModel(
    Guid ModelId,
    string PlateNumber,
    decimal RentCost,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    int Odo
    );