using BLL.Services.Implementations;
using BLL.Services.Interfaces;
using DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.DI;

public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);
        services.AddServices();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IClientService, ClientService>();
        services.AddTransient<IManufacturerService, ManufacturerService>();
        services.AddTransient<IModelNameService, ModelNameService>();
        services.AddTransient<IVehicleClientHistoryService, VehicleClientHistoryService>();
        services.AddTransient<IVehicleService, VehicleService>();
    }
}
