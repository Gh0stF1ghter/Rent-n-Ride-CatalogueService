using DAL.Entities;

namespace DAL.Models;
public record ClientModel(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    Vehicle? Vehicle,
    IEnumerable<VehicleClientHistory> VehicleClientHistories
    );
