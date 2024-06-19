using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class CarModelRepository(AgencyDbContext context) : RepositoryBase<CarModelEntity>(context), ICarModelRepository
{
    public async Task<IEnumerable<CarModelEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
        await GetRange(page, pageSize)
                .Include(m => m.Manufacturer)
                .ToListAsync(cancellationToken);
    public async Task<CarModelEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(m => m.Id == id)
                .Include(m => m.Manufacturer)
                .FirstOrDefaultAsync(cancellationToken);
}