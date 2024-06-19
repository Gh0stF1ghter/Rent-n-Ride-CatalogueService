using BLL.Services.Implementations;
using BLL.Services.Interfaces;
using DAL.DI;
using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BLL.DI;

public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);

        services.AddStackExchangeRedisCache(options =>
            options.Configuration = configuration.GetConnectionString("Redis"));

        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        services.AddServices();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IManufacturerService, ManufacturerService>();
        services.AddScoped<ICarModelService, CarModelService>();
        services.AddScoped<IVehicleClientHistoryService, VehicleClientHistoryService>();
        services.AddScoped<IVehicleService, VehicleService>();
    }
}