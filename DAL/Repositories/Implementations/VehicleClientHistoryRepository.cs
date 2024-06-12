using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class VehicleClientHistoryRepository(AgencyDbContext context) : RepositoryBase<VehicleClientHistory>(context), IVehicleClientHistoryRepository
{
    public async Task<IEnumerable<VehicleClientHistory>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
        await GetRange(page, pageSize)
            .Include(vch => vch.Client)
            .Include(vch => vch.Vehicle)
            .ToListAsync(cancellationToken);

    public async Task<VehicleClientHistory?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(vch => vch.Id == id)
            .FirstOrDefaultAsync(cancellationToken);
}