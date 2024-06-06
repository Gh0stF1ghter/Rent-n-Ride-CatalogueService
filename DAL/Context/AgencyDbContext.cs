using DAL.Entities;
using DAL.TestDataGenerator;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class AgencyDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<ModelName> VehicleModels { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<VehicleClientHistory> VehicleClientHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DataGenerator.Init();

        modelBuilder.Entity<Manufacturer>().HasData(DataGenerator.Manufacturers);
        modelBuilder.Entity<ModelName>().HasData(DataGenerator.VehicleModels);
        modelBuilder.Entity<Vehicle>().HasData(DataGenerator.Vehicles);
        modelBuilder.Entity<Client>().HasData(DataGenerator.Clients);
        modelBuilder.Entity<VehicleClientHistory>().HasData(DataGenerator.VehicleClientHistories);
    }
}