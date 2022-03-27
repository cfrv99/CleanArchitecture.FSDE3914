using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Infrastructure.Caching
{
    public class MemoryCacheService : ICacheService
    {
        private readonly IMemoryCache memoryCache;
        private readonly object _cacheBlocker = new object();

        public MemoryCacheService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }
        public Task AddToCache(string key, object data)
        {
            lock (_cacheBlocker)
            {
                MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions();
                cacheOptions.AbsoluteExpiration = DateTimeOffset.Now;
                cacheOptions.AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(3);
                cacheOptions.SlidingExpiration = TimeSpan.FromDays(1);
                memoryCache.Set(key, data, cacheOptions);
                return Task.CompletedTask;
            }
        }

        public async Task<object> GetFromCache(string key)
        {
            var cacheValue = memoryCache.GetOrCreate(key, (cachEntryOptions) =>
            {
                 cachEntryOptions.SlidingExpiration = TimeSpan.FromDays(3);
                 return "Murad Necesen";
            });
            return cacheValue;
        }

        public Task RemoveFromCache(string key)
        {
            memoryCache.Remove(key);
            return Task.CompletedTask;
        }
    }
}
