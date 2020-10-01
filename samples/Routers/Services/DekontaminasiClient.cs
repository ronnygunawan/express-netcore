using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using Routers.Models;

namespace Routers.Services {
	public class DekontaminasiClient {
		private static string URL = "https://dekontaminasi.com/api/id/covid19/stats";
		private readonly HttpClient _httpClient;

		public DekontaminasiClient(HttpClient httpClient) {
			_httpClient = httpClient;
		}

		public async Task<Covid19Numbers> GetIndonesiaNumbersAsync(CancellationToken cancellationToken) {
			Covid19Stats stats = await _httpClient.GetFromJsonAsync<Covid19Stats>(URL, cancellationToken).ConfigureAwait(false);
			return stats.Numbers;
		}

		public async Task<Covid19Numbers> GetJakartaNumbersAsync(CancellationToken cancellationToken) {
			Covid19Stats stats = await _httpClient.GetFromJsonAsync<Covid19Stats>(URL, cancellationToken).ConfigureAwait(false);
			return stats.Regions.Single(region => region.Name == "DKI Jakarta").Numbers;
		}
	}
}
