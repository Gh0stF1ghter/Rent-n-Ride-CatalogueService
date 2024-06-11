using BLL.Models;
using DAL.Entities;

namespace BLL.Mappers;

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
            ModelName = vehicleModel.Model,
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
            Model: vehicle.ModelName,
            Client: vehicle.Client
            );
}