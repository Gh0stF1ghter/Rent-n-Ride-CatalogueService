using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class VehicleClientHistoryRepository(AgencyDbContext context) : IVehicleClientHistoryRepository
{
    public async Task<IEnumerable<VehicleClientHistory>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.VehicleClientHistories
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<VehicleClientHistory?> GetByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.VehicleClientHistories.FindAsync([id], cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<VehicleClientHistory, bool>> predicate, CancellationToken cancellationToken) =>
        await context.VehicleClientHistories.AnyAsync(predicate, cancellationToken);

    public async Task AddAsync(VehicleClientHistory vehicleClientHistory, CancellationToken cancellationToken)
    {
        await context.VehicleClientHistories.AddAsync(vehicleClientHistory, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
    public async Task RemoveAsync(VehicleClientHistory vehicleClientHistory, CancellationToken cancellationToken)
    {
        context.VehicleClientHistories.Remove(vehicleClientHistory);
        await context.SaveChangesAsync(cancellationToken);
    }
}
