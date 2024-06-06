using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class ManufacturerRepository(AgencyDbContext context) : IManufacturerRepository
{
    public async Task<IEnumerable<Manufacturer>> GetManufacturersRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.Manufacturers
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<Manufacturer?> GetManufacturerByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.Manufacturers.FindAsync([id], cancellationToken);

    public async Task<bool> IsManufacturerExists(Expression<Func<Manufacturer, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Manufacturers.AnyAsync(predicate, cancellationToken: cancellationToken);

    public void AddManufacturer(Manufacturer manufacturer) =>
        context.Manufacturers.Add(manufacturer);
    public void RemoveManufacturer(Manufacturer manufacturer) =>
        context.Manufacturers.Remove(manufacturer);

}
