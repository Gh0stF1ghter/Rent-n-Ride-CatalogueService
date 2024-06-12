using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class VehicleRepository(AgencyDbContext context) : IVehicleRepository
{
    public async Task<IEnumerable<VehicleEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = (page - 1) * pageSize;

        return await context.Vehicles
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(v => v.ModelName)
            .Include(v => v.VehicleClientHistory)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<VehicleEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await context.Vehicles
            .Include(v => v.ModelName)
            .Include(v => v.VehicleClientHistory)
            .AsNoTracking()
            .FirstOrDefaultAsync(v => v.Id == id, cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<VehicleEntity, bool>> predicate, CancellationToken cancellationToken) =>
        context.Vehicles.AnyAsync(predicate, cancellationToken);

    public async Task AddAsync(VehicleEntity vehicle, CancellationToken cancellationToken)
    {
        await context.Vehicles.AddAsync(vehicle, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(VehicleEntity newVehicle, CancellationToken cancellationToken)
    {
        context.Update(newVehicle);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(VehicleEntity vehicle, CancellationToken cancellationToken)
    {
        context.Vehicles.Remove(vehicle);
        await context.SaveChangesAsync(cancellationToken);
    }
}