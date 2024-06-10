using DAL.Entities;

namespace DAL.Models;

public record ClientModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Vehicle? Vehicle { get; set; }
    public IEnumerable<VehicleClientHistory>? VehicleClientHistories { get; set; }
}