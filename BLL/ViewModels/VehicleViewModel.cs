using DAL.Entities;
using DAL.Enums;

namespace BLL.ViewModels;

public record VehicleViewModel(
    Guid Id,
    string PlateNumber,
    int Odo,
    double RentCost,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    ModelNameViewModel? Model,
    ClientViewModel? Client
    );