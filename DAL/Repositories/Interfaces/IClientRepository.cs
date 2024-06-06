using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IClientRepository
{
    public Task<IEnumerable<Client>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);
    public Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<bool> IsExistsAsync(Expression<Func<Client, bool>> predicate, CancellationToken cancellationToken);

    public Task AddAsync(Client client, CancellationToken cancellationToken);

    public Task RemoveAsync(Client client, CancellationToken cancellationToken);
}