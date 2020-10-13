using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace ExpressNetCore {
	public partial class ExpressApp {
		public AuthenticationBuilder AddAuthentication() {
			return _serviceCollection.AddAuthentication();
		}

		public AuthenticationBuilder AddAuthentication(string defaultScheme) {
			return _serviceCollection.AddAuthentication(defaultScheme);
		}

		public AuthenticationBuilder AddAuthentication(Action<AuthenticationOptions> configureOptions) {
			return _serviceCollection.AddAuthentication(configureOptions);
		}
	}
}
