using DAL.Entities;
using DAL.Models;

namespace DAL.Mappers;

internal static class VehicleMapper
{
    public static Vehicle Map(VehicleModel vehicleModel) =>
        new()
        {
            Id = vehicleModel.Id,
            PlateNumber = vehicleModel.PlateNumber,
            Odo = vehicleModel.Odo,
            RentCost = vehicleModel.RentCost,
            VehicleType = vehicleModel.VehicleType,
            VehicleState = vehicleModel.VehicleState,
            FuelType = vehicleModel.FuelType,
            Model = vehicleModel.Model,
            Client = vehicleModel.Client,
        };

    public static VehicleModel Map(Vehicle vehicle) =>
        new(
            Id: vehicle.Id,
            PlateNumber: vehicle.PlateNumber,
            Odo: vehicle.Odo,
            RentCost: vehicle.RentCost,
            VehicleType: vehicle.VehicleType,
            VehicleState: vehicle.VehicleState,
            FuelType: vehicle.FuelType,
            Model: vehicle.Model,
            Client: vehicle.Client
            );
}