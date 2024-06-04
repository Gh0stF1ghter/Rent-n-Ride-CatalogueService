namespace DAL.Entities
{
    public class Model
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}