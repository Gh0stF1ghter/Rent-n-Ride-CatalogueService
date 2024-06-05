using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ServicesConfiguration
{
    public static void ConfigureSqlContext(this IServiceCollection service, IConfiguration configuration) =>
        service.AddDbContext<AgencyDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DBConnection"), x => x.MigrationsAssembly("DAL")));
}
