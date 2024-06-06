using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;
public class VehicleRepository(AgencyDbContext context) : IVehicleRepository
{
    public async Task<IEnumerable<Vehicle>> GetVehiclesRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = page - 1 * pageSize;

        return await context.Vehicles
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
    public async Task<Vehicle?> GetVehicleByIdAsync(int id, CancellationToken cancellationToken) => 
        await context.Vehicles.FindAsync([id], cancellationToken);

    public Task<bool> IsVehicleExists(Expression<Func<Vehicle, bool>> predicate, CancellationToken cancellationToken) =>
        context.Vehicles.AnyAsync(predicate, cancellationToken);

    public void AddVehicle(Vehicle vehicle) =>
        context.Vehicles.Add(vehicle);

    public void RemoveVehicle(Vehicle vehicle) => 
        context.Vehicles.Remove(vehicle);
}
