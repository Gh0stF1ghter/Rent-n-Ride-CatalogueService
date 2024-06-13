using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class VehicleRepository(AgencyDbContext context) : RepositoryBase<VehicleEntity>(context), IVehicleRepository
{
    public async Task<IEnumerable<VehicleEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
        await GetRange(page, pageSize)
            .Include(v => v.ModelName)
            .Include(v => v.VehicleClientHistory)
            .ToListAsync(cancellationToken);

    public async Task<VehicleEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(v => v.Id == id)
            .Include(v => v.ModelName)
            .Include(v => v.VehicleClientHistory)
            .FirstOrDefaultAsync(cancellationToken);
}