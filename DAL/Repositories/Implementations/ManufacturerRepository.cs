using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class ManufacturerRepository(AgencyDbContext context) : IManufacturerRepository
{
    public async Task<IEnumerable<ManufacturerEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = (page - 1) * pageSize;

        return await context.Manufacturers
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<ManufacturerEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await context.Manufacturers
            .Include(m => m.ModelNames)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id, cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<ManufacturerEntity, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Manufacturers.AnyAsync(predicate, cancellationToken: cancellationToken);

    public async Task AddAsync(ManufacturerEntity manufacturer, CancellationToken cancellationToken)
    {
        await context.Manufacturers.AddAsync(manufacturer, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(ManufacturerEntity newManufacturer, CancellationToken cancellationToken)
    {
        context.Manufacturers.Update(newManufacturer);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(ManufacturerEntity manufacturer, CancellationToken cancellationToken)
    {
        context.Manufacturers.Remove(manufacturer);
        await context.SaveChangesAsync(cancellationToken);
    }
}