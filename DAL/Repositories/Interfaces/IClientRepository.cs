using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IClientRepository
{
    Task<IEnumerable<ClientEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ClientEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> IsExistsAsync(Expression<Func<ClientEntity, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(ClientEntity client, CancellationToken cancellationToken);

    Task UpdateAsync(ClientEntity newClient, CancellationToken cancellationToken);

    Task RemoveAsync(ClientEntity client, CancellationToken cancellationToken);
}