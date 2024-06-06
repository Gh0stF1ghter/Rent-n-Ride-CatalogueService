using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IClientRepository
{
    Task<IEnumerable<Client>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<Client, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(Client client, CancellationToken cancellationToken);

    Task RemoveAsync(Client client, CancellationToken cancellationToken);
}