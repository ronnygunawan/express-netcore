using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASPEX {
	public partial class ExpressApp {
		public IServiceCollection AddDbContext<TContext>(Action<DbContextOptionsBuilder>? optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContext : DbContext {
			_serviceCollection.AddDbContext<TContext>(optionsAction, contextLifetime, optionsLifetime);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContext>(Action<DbContextOptionsBuilder, IConfiguration>? optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContext : DbContext {
			ConfigureServices(configuration => {
				_serviceCollection.AddDbContext<TContext>(options => {
					optionsAction?.Invoke(options, configuration);
				}, contextLifetime, optionsLifetime);
			});
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContextService, TContextImplementation>(Action<DbContextOptionsBuilder>? optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContextImplementation : DbContext, TContextService {
			_serviceCollection.AddDbContext<TContextService, TContextImplementation>(optionsAction, contextLifetime, optionsLifetime);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContextService, TContextImplementation>(Action<DbContextOptionsBuilder, IConfiguration>? optionsAction = null, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContextImplementation : DbContext, TContextService {
			ConfigureServices(configuration => {
				_serviceCollection.AddDbContext<TContextService, TContextImplementation>(options => {
					optionsAction?.Invoke(options, configuration);
				}, contextLifetime, optionsLifetime);
			});
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContext>(ServiceLifetime contextLifetime, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContext : DbContext {
			_serviceCollection.AddDbContext<TContext>(contextLifetime, optionsLifetime);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContextService, TContextImplementation>(ServiceLifetime contextLifetime, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped)
			where TContextService : class
			where TContextImplementation : DbContext, TContextService {
			_serviceCollection.AddDbContext<TContextService, TContextImplementation>(contextLifetime, optionsLifetime);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContext>(Action<IServiceProvider, DbContextOptionsBuilder>? optionsAction, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContext : DbContext {
			_serviceCollection.AddDbContext<TContext>(optionsAction, contextLifetime, optionsLifetime);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContext<TContextService, TContextImplementation>(Action<IServiceProvider, DbContextOptionsBuilder>? optionsAction, ServiceLifetime contextLifetime = ServiceLifetime.Scoped, ServiceLifetime optionsLifetime = ServiceLifetime.Scoped) where TContextImplementation : DbContext, TContextService {
			_serviceCollection.AddDbContext<TContextService, TContextImplementation>(optionsAction, contextLifetime, optionsLifetime);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContextPool<TContext>(Action<DbContextOptionsBuilder> optionsAction, int poolSize = 128) where TContext : DbContext {
			_serviceCollection.AddDbContextPool<TContext>(optionsAction, poolSize);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContextPool<TContext>(Action<DbContextOptionsBuilder, IConfiguration> optionsAction, int poolSize = 128) where TContext : DbContext {
			ConfigureServices(configuration => {
				_serviceCollection.AddDbContextPool<TContext>(options => {
					optionsAction.Invoke(options, configuration);
				}, poolSize);
			});
			return _serviceCollection;
		}

		public IServiceCollection AddDbContextPool<TContextService, TContextImplementation>(Action<DbContextOptionsBuilder> optionsAction, int poolSize = 128)
			where TContextService : class
			where TContextImplementation : DbContext, TContextService {
			_serviceCollection.AddDbContextPool<TContextService, TContextImplementation>(optionsAction, poolSize);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContextPool<TContextService, TContextImplementation>(Action<DbContextOptionsBuilder, IConfiguration> optionsAction, int poolSize = 128)
			where TContextService : class
			where TContextImplementation : DbContext, TContextService {
			ConfigureServices(configuration => {
				_serviceCollection.AddDbContextPool<TContextService, TContextImplementation>(options => {
					optionsAction.Invoke(options, configuration);
				}, poolSize);
			});
			return _serviceCollection;
		}

		public IServiceCollection AddDbContextPool<TContext>(Action<IServiceProvider, DbContextOptionsBuilder> optionsAction, int poolSize = 128) where TContext : DbContext {
			_serviceCollection.AddDbContextPool<TContext>(optionsAction, poolSize);
			return _serviceCollection;
		}

		public IServiceCollection AddDbContextPool<TContextService, TContextImplementation>(Action<IServiceProvider, DbContextOptionsBuilder> optionsAction, int poolSize = 128)
			where TContextService : class
			where TContextImplementation : DbContext, TContextService {
			_serviceCollection.AddDbContextPool<TContextService, TContextImplementation>(optionsAction, poolSize);
			return _serviceCollection;
		}
	}
}
