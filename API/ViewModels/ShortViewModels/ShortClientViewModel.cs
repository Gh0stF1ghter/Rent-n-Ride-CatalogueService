namespace API.ViewModels.ShortViewModels;

public record ShortClientViewModel(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    Guid VehicleId
    );