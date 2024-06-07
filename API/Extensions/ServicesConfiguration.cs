using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ServicesConfiguration
{
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<AgencyDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DBConnection"), x => x.MigrationsAssembly("DAL")));
}
