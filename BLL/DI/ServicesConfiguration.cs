using DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.DI;
public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDalDependencies(configuration);
    }
}
