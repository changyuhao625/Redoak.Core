using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using IMemoryCache = Redoak.Core.Cache.Interface.IMemoryCache;

namespace Redoak.Core.Cache.Service
{
    public class MemoryCache : Microsoft.Extensions.Caching.Memory.MemoryCache, IMemoryCache
    {
        public MemoryCache(IOptions<MemoryCacheOptions> optionsAccessor) : base(optionsAccessor)
        {
        }
    }
}