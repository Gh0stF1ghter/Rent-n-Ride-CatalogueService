using DAL.Entities;
using DAL.Enums;

namespace DAL.Models;

public record VehicleModel
{
    public Guid Id { get; set; }

    public string PlateNumber { get; set; } = string.Empty;
    public int Odo { get; set; }
    public double RentCost { get; set; }

    public VehicleType VehicleType { get; set; }
    public VehicleState VehicleState { get; set; }
    public FuelType FuelType { get; set; }

    public Guid ModelId { get; set; }
    public ModelName? Model { get; set; }

    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
}