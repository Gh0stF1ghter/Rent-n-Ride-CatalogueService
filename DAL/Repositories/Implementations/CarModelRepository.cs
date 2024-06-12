using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class CarModelRepository(AgencyDbContext context) : ICarModelRepository
{
    public async Task<IEnumerable<CarModelEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = (page - 1) * pageSize;

        return await context.VehicleModels
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(m => m.Manufacturer)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<CarModelEntity?> GetByIdAsync(Guid id, bool trackingChanges, CancellationToken cancellationToken) =>
        trackingChanges ?
        await context.VehicleModels
            .Include(m => m.Manufacturer)
            .FirstOrDefaultAsync(m => m.Id == id, cancellationToken) :
        await context.VehicleModels
            .Include(m => m.Manufacturer)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<CarModelEntity, bool>> predicate, CancellationToken cancellationToken) =>
        await context.VehicleModels.AnyAsync(predicate, cancellationToken);

    public async Task AddAsync(CarModelEntity modelName, CancellationToken cancellationToken)
    {
        await context.VehicleModels.AddAsync(modelName, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(CarModelEntity newModelName, CancellationToken cancellationToken)
    {
        context.Update(newModelName);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(CarModelEntity modelName, CancellationToken cancellationToken)
    {
        context.VehicleModels.Remove(modelName);
        await context.SaveChangesAsync(cancellationToken);
    }
}