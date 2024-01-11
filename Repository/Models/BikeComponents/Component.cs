namespace Repository.Models
{
    public abstract class Component
    {
        public long Id { get; set; }

        public Model Model { get; set; }

        public BikeComponentType SpecificationType { get; set; }

        public ICollection<Bike> Bikes { get; set; }
    }
}
