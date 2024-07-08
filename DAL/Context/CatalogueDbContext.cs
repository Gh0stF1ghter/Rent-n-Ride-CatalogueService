using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class CatalogueDbContext : DbContext
{
    public CatalogueDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) =>
        Database.Migrate();

    public DbSet<ManufacturerEntity> Manufacturers { get; set; }
    public DbSet<CarModelEntity> CarModels { get; set; }
    public DbSet<VehicleEntity> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Database.Migrate();

        DataGenerator.Init();

        modelBuilder.Entity<ManufacturerEntity>().HasData(DataGenerator.Manufacturers);
        modelBuilder.Entity<CarModelEntity>().HasData(DataGenerator.CarModels);
        modelBuilder.Entity<VehicleEntity>().HasData(DataGenerator.Vehicles);
    }
}