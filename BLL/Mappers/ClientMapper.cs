using DAL.Entities;
using DAL.Models;

namespace DAL.Mappers;

internal static class ClientMapper
{
    public static Client Map(ClientModel clientModel) =>
        new()
        {
            Id = clientModel.Id,
            FirstName = clientModel.FirstName,
            LastName = clientModel.LastName,
            Email = clientModel.Email,
            PhoneNumber = clientModel.PhoneNumber,
            Vehicle = clientModel.Vehicle,
            VehicleClientHistory = clientModel.VehicleClientHistories
        };

    public static ClientModel Map(Client client) =>
        new(
            Id: client.Id,
            FirstName: client.FirstName,
            LastName: client.LastName,
            Email: client.Email,
            PhoneNumber: client.PhoneNumber,
            Vehicle: client.Vehicle,
            VehicleClientHistories: client.VehicleClientHistory
            );
}