using DAL.Entities;

namespace BLL.ViewModels;

public record ClientViewModel(
    Guid Id,
    string FullName,
    string Email,
    string PhoneNumber,
    Vehicle? Vehicle,
    IEnumerable<VehicleClientHistory> VehicleClientHistories
    );