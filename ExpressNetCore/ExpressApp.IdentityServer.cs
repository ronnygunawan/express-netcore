using System;
using IdentityServer4.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExpressNetCore {
	public partial class ExpressApp {
		internal bool UseIdentityServer { get; private set; }

		public IIdentityServerBuilder AddIdentityServer() {
			UseIdentityServer = true;
			return _serviceCollection.AddIdentityServer();
		}

		public IIdentityServerBuilder AddIdentityServer(Action<IdentityServerOptions> setupAction) {
			UseIdentityServer = true;
			return _serviceCollection.AddIdentityServer(setupAction);
		}

		public IIdentityServerBuilder AddIdentityServer(IConfiguration configuration) {
			UseIdentityServer = true;
			return _serviceCollection.AddIdentityServer(configuration);
		}
	}
}
