namespace Repository.Models
{
    public class Bike
    {
        public long Id { get; set; }

        public Model Model { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public ICollection<Component> BikeComponents { get; set; }
    }
}
