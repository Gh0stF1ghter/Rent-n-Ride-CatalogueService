using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Text;

namespace DAL.Extensions;
internal static class Cache
{
    public static T GetDataFromCache<T>(this byte[] cache)
    {
        var serializedData = Encoding.UTF8.GetString(cache);
        var data = JsonConvert.DeserializeObject<T>(serializedData)!;

        return data;
    }

    public static (byte[], DistributedCacheEntryOptions) ConvertDataForCaching<T>(this T data)
    {
        var serializedData = JsonConvert.SerializeObject(data);

        var bytedData = Encoding.UTF8.GetBytes(serializedData);

        var options = new DistributedCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(2))
            .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10));

        return (bytedData, options);
    }
}