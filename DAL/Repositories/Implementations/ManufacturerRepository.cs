using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;

public class ManufacturerRepository(AgencyDbContext context) : RepositoryBase<Manufacturer>(context), IManufacturerRepository
{
    public async Task<IEnumerable<Manufacturer>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
       await GetRange(page, pageSize)
            .ToListAsync(cancellationToken);

    public async Task<Manufacturer?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(m => m.Id == id)
            .Include(m => m.ModelNames)
            .FirstOrDefaultAsync(cancellationToken);
}