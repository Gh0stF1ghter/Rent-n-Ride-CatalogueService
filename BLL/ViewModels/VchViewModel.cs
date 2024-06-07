using DAL.Entities;

namespace BLL.ViewModels;
public record VchViewModel(
    Guid Id,
    DateTime UseTime,
    Vehicle? Vehicle,
    Client? Client
    );