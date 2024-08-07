using DAL.Context;
using DAL.Entities;
using DAL.QueryParameters;
using DAL.Repositories.Extensions;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class VehicleRepository(CatalogueDbContext context) : RepositoryBase<VehicleEntity>(context), IVehicleRepository
{
    public async Task<IEnumerable<VehicleEntity>> GetRangeAsync(int page, int pageSize, VehicleParameters? parameters, CancellationToken cancellationToken) =>
        await context.Vehicles
            .Filter(parameters)
            .Skip(page - 1)
            .Take(pageSize)
            .AsNoTracking()
            .Include(v => v.CarModel)
            .ThenInclude(cm => cm.Manufacturer)
            .IgnoreAutoIncludes()
            .ToListAsync(cancellationToken);

    public async Task<VehicleEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(v => v.Id == id)
            .Include(v => v.CarModel)
            .FirstOrDefaultAsync(cancellationToken);
}