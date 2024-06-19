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

        var cacheList = await cache.GetDataFromCacheAsync<IEnumerable<CarModelEntity>>(key, cancellationToken);

        if (cacheList is not null)
        {
            return cacheList;
        }
        else
        {
            var list = await GetRange(page, pageSize)
                .Include(m => m.Manufacturer)
                .ToListAsync(cancellationToken);

            var cacheLifetime = TimeSpan.FromMinutes(3);

            await cache.ConvertDataForCaching(list, cacheLifetime, key, cancellationToken);

            return list;
        }
    }

    public async Task<CarModelEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = _cacheIdKeyBase + id;

        var cacheEntity = await cache.GetDataFromCacheAsync<CarModelEntity>(key, cancellationToken);

        if (cacheEntity is not null)
        {
            return cacheEntity;
        }
        else
        {
            var entity = await GetByCondition(m => m.Id == id)
                .Include(m => m.Manufacturer)
                .FirstOrDefaultAsync(cancellationToken);

            var cacheLifetime = TimeSpan.FromMinutes(10);

            await cache.ConvertDataForCaching(entity, cacheLifetime, key, cancellationToken);

            return entity;
        }
    }
}