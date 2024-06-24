using Catalog.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccess.Context;

public class CatalogDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<ManufacturerEntity> Manufacturers { get; set; }
    public DbSet<CarModelEntity> VehicleModels { get; set; }
    public DbSet<VehicleEntity> Vehicles { get; set; }

}
