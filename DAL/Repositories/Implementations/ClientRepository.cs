using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class ClientRepository(AgencyDbContext context) : IClientRepository
{
    public async Task<IEnumerable<Client>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    { 
        var rowsToSkip = page - 1 * pageSize;

        return await context.Clients
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(c => c.Vehicle).AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await context.Clients
            .Include(c => c.Vehicle)
            .Include(c => c.VehicleClientHistory)    
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken: cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<Client, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Clients.AnyAsync(predicate, cancellationToken: cancellationToken);

    public async Task AddAsync(Client client, CancellationToken cancellationToken) 
    {
        await context.Clients.AddAsync(client, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(Client client, CancellationToken cancellationToken)
    {
        context.Clients.Remove(client);
        await context.SaveChangesAsync(cancellationToken);
    }
}