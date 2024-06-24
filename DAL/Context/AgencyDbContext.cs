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
}