using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class ModelNameRepository(AgencyDbContext context) : RepositoryBase<ModelName>(context), IModelNameRepository
{
    public async Task<IEnumerable<ModelName>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = (page - 1) * pageSize;

        return await context.VehicleModels
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(m => m.Manufacturer)
            .ToListAsync(cancellationToken);
    }

    public async Task<ModelName?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await context.VehicleModels
            .Include(m => m.Manufacturer)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);
}