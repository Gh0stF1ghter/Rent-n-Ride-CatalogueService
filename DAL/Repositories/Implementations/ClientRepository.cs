using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations;

public class ClientRepository(AgencyDbContext context) : IClientRepository
{
    public async Task<IEnumerable<ClientEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var rowsToSkip = (page - 1) * pageSize;

        return await context.Clients
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(c => c.VehicleClientHistory)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<ClientEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await context.Clients
            .Include(c => c.VehicleClientHistory)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken: cancellationToken);

    public async Task<bool> IsExistsAsync(Expression<Func<ClientEntity, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Clients.AnyAsync(predicate, cancellationToken: cancellationToken);

    public async Task AddAsync(ClientEntity client, CancellationToken cancellationToken)
    {
        await context.Clients.AddAsync(client, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(ClientEntity newClient, CancellationToken cancellationToken)
    {
        context.Clients.Update(newClient);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task RemoveAsync(ClientEntity client, CancellationToken cancellationToken)
    {
        context.Clients.Remove(client);
        await context.SaveChangesAsync(cancellationToken);
    }
}