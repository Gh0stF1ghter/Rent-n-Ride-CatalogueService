using BLL.Models;
using DAL.Entities;

namespace BLL.Mappers;

internal static class VchMapper
{
    public static VehicleClientHistory Map(VchModel vchModel) =>
        new()
        {
            Id = vchModel.Id,
            StartDate = vchModel.StartDate,
            EndDate = vchModel.EndDate,
            Vehicle = vchModel.Vehicle,
            Client = vchModel.Client,
        };

    public static VchModel Map(VehicleClientHistory vehicleClientHistory) =>
        new(
            Id: vehicleClientHistory.Id,
            StartDate: vehicleClientHistory.StartDate,
            EndDate: vehicleClientHistory.EndDate,
            Vehicle: vehicleClientHistory.Vehicle,
            Client: vehicleClientHistory.Client
            );
}