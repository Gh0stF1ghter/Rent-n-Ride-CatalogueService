using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.DI;

public static class ServicesConfiguration
{
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<AgencyDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DBConnection")));
}
