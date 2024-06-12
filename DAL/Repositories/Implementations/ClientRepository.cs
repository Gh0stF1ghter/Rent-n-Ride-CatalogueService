using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class ClientRepository(AgencyDbContext context) : RepositoryBase<Client>(context), IClientRepository
{
    public async Task<IEnumerable<Client>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
        await GetRange(page, pageSize)
            .Include(c => c.VehicleClientHistory)
            .ToListAsync(cancellationToken);

    public async Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(c => c.Id == id)
            .Include(c => c.VehicleClientHistory)
            .FirstOrDefaultAsync(cancellationToken);
}