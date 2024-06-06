using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class VehicleClientHistoryRepository(AgencyDbContext context) : IVehicleClientHistoryRepository
{
    public async Task<IEnumerable<VehicleClientHistory>> GetVehicleClientHistoriesRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.VehicleClientHistories
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<VehicleClientHistory?> GetVehicleClientHistoryByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.VehicleClientHistories.FindAsync([id], cancellationToken);

    public async Task<bool> IsVehicleClientHistoryExists(Expression<Func<VehicleClientHistory, bool>> predicate, CancellationToken cancellationToken) =>
        await context.VehicleClientHistories.AnyAsync(predicate, cancellationToken);

    public void AddVehicleClientHistory(VehicleClientHistory vehicleClientHistory) =>
        context.VehicleClientHistories.Add(vehicleClientHistory);
    public void RemoveVehicleClientHistory(VehicleClientHistory vehicleClientHistory) =>
        context.VehicleClientHistories.Remove(vehicleClientHistory);

}
