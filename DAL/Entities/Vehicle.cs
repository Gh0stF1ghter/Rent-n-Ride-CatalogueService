using DAL.Enums;

namespace DAL.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public int PlateNumber { get; set; }
        public int Odo { get; set; }
        public double RentCost { get; set; }

        public Guid ModelId { get; set; }
        public Model Model { get; set; }

        public Guid TypeId { get; set; }
        public VehicleType VehicleType { get; set; }

        public VehicleState VehicleState { get; set; }
        public FuelType FuelType { get; set; }


        public IEnumerable<VehicleClientHistory> VehicleClientHistory { get; set; }
    }
}