using System.Threading;
using System.Threading.Tasks;
using ASPEX.Routing;
using Routers.Models;
using Routers.Services;

namespace Routers.Routers {
	public class Covid19Router {
		private readonly DekontaminasiClient _client;

		public Covid19Router(DekontaminasiClient client) {
			_client = client;
		}

		[MapGet("")]
		public Task<Covid19Numbers> GetIndonesiaNumbersAsync(CancellationToken cancellationToken) {
			return _client.GetIndonesiaNumbersAsync(cancellationToken);
		}

		[MapGet("jakarta")]
		public Task<Covid19Numbers> GetJakartaNumbersAsync(CancellationToken cancellationToken) {
			return _client.GetJakartaNumbersAsync(cancellationToken);
		}
	}
}
