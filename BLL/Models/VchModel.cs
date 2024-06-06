using DAL.Entities;

namespace DAL.Models;

public record VchModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    Vehicle? Vehicle,
    Client? Client
    );