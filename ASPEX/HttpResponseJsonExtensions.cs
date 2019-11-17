using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ASPEX {
	public static class HttpResponseJsonExtensions {
		public static Task WriteJsonAsync(this HttpResponse response, object value, Encoding encoding, CancellationToken cancellationToken = default) {
			string text = JsonConvert.SerializeObject(value);
			return response.WriteAsync(text, encoding, cancellationToken);
		}

		public static Task WriteJsonAsync(this HttpResponse response, object value, CancellationToken cancellationToken = default) {
			string text = JsonConvert.SerializeObject(value);
			return response.WriteAsync(text, cancellationToken);
		}
	}
}
