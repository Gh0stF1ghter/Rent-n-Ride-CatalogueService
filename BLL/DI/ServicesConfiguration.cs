using BLL.Services.Implementations;
using BLL.Services.Interfaces;
using DAL.DI;
using Mapster;
using MassTransit;
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

        services.AddMessageBroker(configuration);

        services.AddServices();
    }

    public static void AddMessageBroker(this IServiceCollection services, IConfiguration configuration) =>
    services.AddMassTransit(cfg =>
    {
        var assembly = Assembly.GetExecutingAssembly();

        cfg.AddConsumers(assembly);

        cfg.UsingRabbitMq((context, factoryCfg) =>
        {
            factoryCfg.Host(configuration.GetConnectionString("RabbitMQ"), "/");

            factoryCfg.ConfigureEndpoints(context);
        });
    });

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IManufacturerService, ManufacturerService>();
        services.AddScoped<ICarModelService, CarModelService>();
        services.AddScoped<IVehicleService, VehicleService>();
    }
}