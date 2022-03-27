using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Infrastructure.Caching
{
    public interface ICacheService
    {
        Task AddToCache(string key, object data);
        Task RemoveFromCache(string key);
        Task<object> GetFromCache(string key);

    }
}
