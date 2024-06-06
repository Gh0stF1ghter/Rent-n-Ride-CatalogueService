using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class VehicleModelRepository(AgencyDbContext context) : IVehicleModelRepository
{
    public async Task<IEnumerable<VehicleModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = (page - 1) * pageSize;

        return await context.VehicleModels
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(m => m.Manufacturer)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<VehicleModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await context.VehicleModels
            .Include(m => m.Manufacturer)
            .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<VehicleModel, bool>> predicate, CancellationToken cancellationToken) =>
        await context.VehicleModels.AnyAsync(predicate, cancellationToken);

    public async Task AddAsync(VehicleModel model, CancellationToken cancellationToken)
    {
        await context.VehicleModels.AddAsync(model, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(VehicleModel model, CancellationToken cancellationToken) 
    {
        context.VehicleModels.Remove(model);
        await context.SaveChangesAsync(cancellationToken);
    }
}