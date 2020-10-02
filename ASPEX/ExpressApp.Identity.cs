using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ASPEX {
	public partial class ExpressApp {
		public IdentityBuilder AddDefaultIdentity<TUser>() where TUser : class {
			return _serviceCollection.AddDefaultIdentity<TUser>();
		}

		public IdentityBuilder AddDefaultIdentity<TUser>(Action<IdentityOptions> configureOptions) where TUser : class {
			return _serviceCollection.AddDefaultIdentity<TUser>(configureOptions);
		}
	}
}
