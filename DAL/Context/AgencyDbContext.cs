using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;
public class AgencyDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<VehicleModel> VehicleModels { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<VehicleClientHistory> VehicleClientHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
