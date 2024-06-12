using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class ModelNameRepository(AgencyDbContext context) : RepositoryBase<ModelName>(context), IModelNameRepository
{
    public async Task<IEnumerable<ModelName>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
        await GetRange(page, pageSize)
            .Include(m => m.Manufacturer)
            .ToListAsync(cancellationToken);
    

    public async Task<ModelName?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(m => m.Id == id)
            .Include(m => m.Manufacturer)
            .FirstOrDefaultAsync(cancellationToken);
}