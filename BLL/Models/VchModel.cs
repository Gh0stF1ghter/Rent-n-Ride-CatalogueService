using DAL.Entities;

namespace BLL.Models;

public record VchModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    Vehicle? Vehicle,
    Client? Client
    );