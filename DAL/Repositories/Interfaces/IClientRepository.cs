using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IClientRepository : IRepositoryBase<ClientEntity>
{
    Task<IEnumerable<ClientEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ClientEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}