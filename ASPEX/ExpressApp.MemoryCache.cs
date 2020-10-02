using System;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace ASPEX {
	public partial class ExpressApp {
		public IServiceCollection AddMemoryCache() {
			_serviceCollection.AddMemoryCache();
			return _serviceCollection;
		}

		public IServiceCollection AddMemoryCache(Action<MemoryCacheOptions> setupAction) {
			_serviceCollection.AddMemoryCache(setupAction);
			return _serviceCollection;
		}

		public IServiceCollection AddDistributedMemoryCache() {
			_serviceCollection.AddDistributedMemoryCache();
			return _serviceCollection;
		}

		public IServiceCollection AddDistributedMemoryCache(Action<MemoryDistributedCacheOptions> setupAction) {
			_serviceCollection.AddDistributedMemoryCache(setupAction);
			return _serviceCollection;
		}
	}
}
