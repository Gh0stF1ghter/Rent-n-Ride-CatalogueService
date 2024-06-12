using DAL.Enums;

namespace BLL.Models;

public record VehicleModel(
    Guid Id,
    string PlateNumber,
    int Odo,
    double RentCost,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    CarModel? Model,
    ClientModel? Client
    );