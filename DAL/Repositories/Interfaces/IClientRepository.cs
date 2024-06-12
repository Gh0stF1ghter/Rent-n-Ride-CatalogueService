using DAL.Entities;
using System.Linq.Expressions;

namespace DAL.Repositories.Interfaces;

public interface IClientRepository : IRepositoryBase<Client>
{
    Task<IEnumerable<Client>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}