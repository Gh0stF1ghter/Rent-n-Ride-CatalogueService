namespace DAL.Entities;

public class VehicleClientHistoryEntity
{
    public Guid Id { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Guid VehicleId { get; set; }
    public VehicleEntity? Vehicle { get; set; }

    public Guid ClientId { get; set; }
    public ClientEntity? Client { get; set; }
}