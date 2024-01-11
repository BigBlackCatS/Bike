using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Models.BikeComponents;

namespace Repository
{
    public class BikeDbContext : DbContext
    {
        public BikeDbContext(DbContextOptions<BikeDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet<Bike> Bike { get; set; }

        public DbSet<Brand> Brand { get; set; }

        public DbSet<Model> Model { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Component>()
                .HasDiscriminator(b => b.SpecificationType)
                .HasValue<Frame>(BikeComponentType.Frame);
        }
    }
}
