using DAL.Context;
using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.DI;

public static class ServicesConfiguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CatalogueDbContext>(options => options.UseNpgsql($"{configuration.GetConnectionString("DBConnection")} User ID={Environment.GetEnvironmentVariable("POSTGRES_USER")}; Password={Environment.GetEnvironmentVariable("POSTGRES_PASSWORD")}"));

        services.AddTransient<IManufacturerRepository, ManufacturerRepository>();
        services.AddTransient<ICarModelRepository, CarModelRepository>();
        services.AddTransient<IVehicleRepository, VehicleRepository>();
    }
}