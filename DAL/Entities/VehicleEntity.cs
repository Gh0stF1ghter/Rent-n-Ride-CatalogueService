using DAL.Enums;

namespace DAL.Entities;

public class VehicleEntity
{
    public Guid Id { get; set; }

    public string PlateNumber { get; set; } = string.Empty;
    public int Odo { get; set; }
    public decimal RentCost { get; set; }
    public bool IsRented { get; set; }

    public VehicleType VehicleType { get; set; }
    public VehicleState VehicleState { get; set; }
    public FuelType FuelType { get; set; }

    public Guid CarModelId { get; set; }
    public CarModelEntity? CarModel { get; set; }
}