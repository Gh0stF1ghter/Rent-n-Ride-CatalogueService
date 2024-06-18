using DAL.Context;
using DAL.Entities;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;

namespace DAL.Repositories.Implementations;

public class CarModelRepository(AgencyDbContext context, IDistributedCache cache) : RepositoryBase<CarModelEntity>(context), ICarModelRepository
{
    private const string _cacheListKeyBase = "AllModels";
    private const string _cacheIdKeyBase = "Model";

    public async Task<IEnumerable<CarModelEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) 
    {
        var key = _cacheListKeyBase + page + pageSize;

        var cacheList = await cache.GetAsync(key, cancellationToken);

        IEnumerable<CarModelEntity> list;

        if (cacheList is not null)
        {
            list = cacheList.GetDataFromCache<List<CarModelEntity>>();
        }
        else
        {
            list = await GetRange(page, pageSize)
                .Include(m => m.Manufacturer)
                .ToListAsync(cancellationToken);

            (var listToCache, var options) = list.ConvertDataForCaching();

            await cache.SetAsync(key, listToCache, options, cancellationToken);
        }

        return list;
    }

    public async Task<CarModelEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(m => m.Id == id)
            .Include(m => m.Manufacturer)
            .FirstOrDefaultAsync(cancellationToken);
}