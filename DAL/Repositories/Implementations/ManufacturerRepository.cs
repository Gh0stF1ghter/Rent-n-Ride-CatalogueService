using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class ManufacturerRepository(AgencyDbContext context) : IManufacturerRepository
{
    public async Task<IEnumerable<Manufacturer>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.Manufacturers
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<Manufacturer?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.Manufacturers.FindAsync([id], cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<Manufacturer, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Manufacturers.AnyAsync(predicate, cancellationToken: cancellationToken);

    public async Task AddAsync(Manufacturer manufacturer, CancellationToken cancellationToken)
    {
        await context.Manufacturers.AddAsync(manufacturer, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
    public async Task RemoveAsync(Manufacturer manufacturer, CancellationToken cancellationToken)
    {
        context.Manufacturers.Remove(manufacturer);
        await context.SaveChangesAsync(cancellationToken);
    }
}