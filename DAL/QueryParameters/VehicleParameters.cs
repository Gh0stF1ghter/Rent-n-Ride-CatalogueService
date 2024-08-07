using DAL.Enums;

namespace DAL.QueryParameters;

public class VehicleParameters
{
    public FuelType? FuelType { get; set; }

    public VehicleType? VehicleType { get; set; }

    public VehicleState? VehicleState { get; set; }

    public Guid? CarModelId { get; set; }
}
