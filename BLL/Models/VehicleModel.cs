using DAL.Entities;
using DAL.Enums;

namespace DAL.Models;

public record VehicleModel(
    Guid Id,
    string PlateNumber,
    int Odo,
    double RentCost,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    Model? Model,
    Client? Client
    );