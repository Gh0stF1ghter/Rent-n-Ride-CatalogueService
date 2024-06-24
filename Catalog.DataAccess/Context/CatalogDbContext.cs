using Catalog.DataAccess.Entities;
using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccess.Context;

public class CatalogDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<ManufacturerEntity> Manufacturers { get; set; }
    public DbSet<CarModelEntity> CarModelEntities { get; set; }
    public DbSet<VehicleEntity> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DataGenerator.Init();

        modelBuilder.Entity<ManufacturerEntity>().HasData(DataGenerator.Manufacturers);
        modelBuilder.Entity<CarModelEntity>().HasData(DataGenerator.CarModelEntities);
        modelBuilder.Entity<VehicleEntity>().HasData(DataGenerator.Vehicles);
    }
}