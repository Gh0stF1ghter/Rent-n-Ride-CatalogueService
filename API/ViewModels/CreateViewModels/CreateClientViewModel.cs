namespace BLL.ViewModels;

public record CreateClientViewModel(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    Guid VehicleId
    );