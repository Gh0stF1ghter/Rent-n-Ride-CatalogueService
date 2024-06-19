using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;

namespace DAL.Repositories.Implementations;

public class ClientRepository(AgencyDbContext context, IDistributedCache cache) : RepositoryBase<ClientEntity>(context), IClientRepository
{
    private const string _cacheListKeyBase = "AllClients";
    private const string _cacheEntityKeyBase = "Client";

    public async Task<IEnumerable<ClientEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) 
    {
        var key = _cacheListKeyBase + page + pageSize;



       return await GetRange(page, pageSize)
            .Include(c => c.VehicleClientHistory)
            .ToListAsync(cancellationToken); 
    }

    public async Task<ClientEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(c => c.Id == id)
            .Include(c => c.VehicleClientHistory)
            .FirstOrDefaultAsync(cancellationToken);
}