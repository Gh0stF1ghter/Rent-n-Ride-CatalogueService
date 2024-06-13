using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class AgencyDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<ClientEntity> Clients { get; set; }
    public DbSet<ManufacturerEntity> Manufacturers { get; set; }
    public DbSet<CarModelEntity> VehicleModels { get; set; }
    public DbSet<VehicleEntity> Vehicles { get; set; }
    public DbSet<VehicleClientHistoryEntity> VehicleClientHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DataGenerator.Init();

        modelBuilder.Entity<ManufacturerEntity>().HasData(DataGenerator.Manufacturers);
        modelBuilder.Entity<CarModelEntity>().HasData(DataGenerator.VehicleModels);
        modelBuilder.Entity<VehicleEntity>().HasData(DataGenerator.Vehicles);
        modelBuilder.Entity<ClientEntity>().HasData(DataGenerator.Clients);
        modelBuilder.Entity<VehicleClientHistoryEntity>().HasData(DataGenerator.VehicleClientHistories);
    }
}