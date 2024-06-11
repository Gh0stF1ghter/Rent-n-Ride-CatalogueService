using DAL.Entities;

namespace API.ViewModels;

public record ClientViewModel(
    Guid Id,
    string FullName,
    string Email,
    string PhoneNumber,
    VehicleViewModel? Vehicle,
    IEnumerable<VchViewModel> VehicleClientHistories
    );