using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;
public interface IClientRepository
{
    public Task<IEnumerable<Client>> GetClientsRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Client?> GetClientByIdAsync(int id, CancellationToken cancellationToken);

    public Task<bool> IsClientExists(Expression<Func<Client, bool>> predicate, CancellationToken cancellationToken);

    public void AddClient(Client client);
    public void RemoveClient(Client client);
}