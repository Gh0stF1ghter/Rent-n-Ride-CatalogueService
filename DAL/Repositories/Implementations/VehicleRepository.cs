using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class VehicleRepository(AgencyDbContext context) : IVehicleRepository
{
    public async Task<IEnumerable<Vehicle>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.Vehicles
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(v => v.Model)
            .Include(v => v.Client)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<Vehicle?> GetByIdAsync(Guid id, CancellationToken cancellationToken) => 
        await context.Vehicles
            .Include(v => v.Model)
            .Include(v => v.Client)
            .Include(v => v.VehicleClientHistory)
            .FirstOrDefaultAsync(v => v.Id == id, cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<Vehicle, bool>> predicate, CancellationToken cancellationToken) =>
        context.Vehicles.AnyAsync(predicate, cancellationToken);

    public async Task AddAsync(Vehicle vehicle, CancellationToken cancellationToken)
    {
        await context.Vehicles.AddAsync(vehicle, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(Vehicle vehicle, CancellationToken cancellationToken)
    {
        context.Vehicles.Remove(vehicle);
        await context.SaveChangesAsync(cancellationToken);
    } 
}