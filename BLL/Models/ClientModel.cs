using DAL.Entities;

namespace BLL.Models;

public record ClientModel(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    Vehicle? Vehicle,
    IEnumerable<VehicleClientHistory> VehicleClientHistories
    );