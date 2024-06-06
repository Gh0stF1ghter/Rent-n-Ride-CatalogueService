using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DAL.Repositories.Implementations;
public class ClientRepository(AgencyDbContext context) : IClientRepository
{
    public async Task<IEnumerable<Client>> GetClientsRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    { 
        var rowsToSkip = page - 1 * pageSize;

        return await context.Clients
            .Skip(rowsToSkip)
            .Take(pageSize)
            .Include(c => c.Vehicle).AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<Client?> GetClientByIdAsync(int id, CancellationToken cancellationToken) =>
        await context.Clients.FindAsync([id], cancellationToken: cancellationToken);

    public async Task<bool> IsClientExists(Expression<Func<Client, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Clients.AnyAsync(predicate, cancellationToken: cancellationToken);

    public void AddClient(Client client) =>
        context.Clients.Add(client);

    public void RemoveClient(Client client) =>
        context.Clients.Remove(client);
}