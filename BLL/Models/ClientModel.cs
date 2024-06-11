namespace BLL.Models;

public record ClientModel(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    VehicleModel? Vehicle,
    IEnumerable<VchModel> VehicleClientHistories
    );