using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Routers.Models;

namespace Routers.Services {
	public class DekontaminasiClient {
		private static string URL = "https://dekontaminasi.com/api/id/covid19/stats";
		private readonly HttpClient _httpClient;
		private readonly IMemoryCache _memoryCache;

		public DekontaminasiClient(HttpClient httpClient, IMemoryCache memoryCache) {
			_httpClient = httpClient;
			_memoryCache = memoryCache;
		}

		public async Task<Covid19Numbers> GetIndonesiaNumbersAsync(CancellationToken cancellationToken) {
			Covid19Stats stats = await GetStatsAsync(cancellationToken).ConfigureAwait(false);
			return stats.Numbers;
		}

		public async Task<Covid19Numbers> GetJakartaNumbersAsync(CancellationToken cancellationToken) {
			Covid19Stats stats = await GetStatsAsync(cancellationToken).ConfigureAwait(false);
			return stats.Regions.Single(region => region.Name == "DKI Jakarta").Numbers;
		}

		private async Task<Covid19Stats> GetStatsAsync(CancellationToken cancellationToken) {
			return await _memoryCache.GetOrCreateAsync(nameof(Covid19Stats), async entry => {
				Covid19Stats stats = await _httpClient.GetFromJsonAsync<Covid19Stats>(URL, cancellationToken).ConfigureAwait(false);
				entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10);
				return stats;
			});
		}
	}
}
