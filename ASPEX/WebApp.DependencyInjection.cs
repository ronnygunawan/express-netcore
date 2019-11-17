using Microsoft.Extensions.DependencyInjection;
using System;

namespace ASPEX {
	public partial class WebApp {
		public IServiceCollection AddScoped(Type serviceType) {
			_serviceCollection.AddScoped(serviceType);
			return _serviceCollection;
		}

		public IServiceCollection AddScoped(Type serviceType, Func<IServiceProvider, object> implementationFactory) {
			_serviceCollection.AddScoped(serviceType, implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddScoped(Type serviceType, Type implementationType) {
			_serviceCollection.AddScoped(serviceType, implementationType);
			return _serviceCollection;
		}

		public IServiceCollection AddScoped<TService>() where TService : class {
			_serviceCollection.AddScoped<TService>();
			return _serviceCollection;
		}

		public IServiceCollection AddScoped<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class {
			_serviceCollection.AddScoped(implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddScoped<TService, TImplementation>()
			where TService : class
			where TImplementation : class, TService {
			_serviceCollection.AddScoped<TService, TImplementation>();
			return _serviceCollection;
		}

		public IServiceCollection AddScoped<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
			where TService : class
			where TImplementation : class, TService {
			_serviceCollection.AddScoped(implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
			where TService : class
			where TImplementation : class, TService {
			_serviceCollection.AddSingleton(implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton<TService, TImplementation>()
			where TService : class
			where TImplementation : class, TService {
			_serviceCollection.AddSingleton<TService, TImplementation>();
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton<TService>(TService implementationInstance) where TService : class {
			_serviceCollection.AddSingleton(implementationInstance);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class {
			_serviceCollection.AddSingleton(implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton<TService>() where TService : class {
			_serviceCollection.AddSingleton<TService>();
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton(Type serviceType, Type implementationType) {
			_serviceCollection.AddSingleton(serviceType, implementationType);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton(Type serviceType, object implementationInstance) {
			_serviceCollection.AddSingleton(serviceType, implementationInstance);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton(Type serviceType, Func<IServiceProvider, object> implementationFactory) {
			_serviceCollection.AddSingleton(serviceType, implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddSingleton(Type serviceType) {
			_serviceCollection.AddSingleton(serviceType);
			return _serviceCollection;
		}

		public IServiceCollection AddTransient(Type serviceType) {
			_serviceCollection.AddTransient(serviceType);
			return _serviceCollection;
		}

		public IServiceCollection AddTransient(Type serviceType, Func<IServiceProvider, object> implementationFactory) {
			_serviceCollection.AddTransient(serviceType, implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddTransient(Type serviceType, Type implementationType) {
			_serviceCollection.AddTransient(serviceType, implementationType);
			return _serviceCollection;
		}

		public IServiceCollection AddTransient<TService>() where TService : class {
			_serviceCollection.AddTransient<TService>();
			return _serviceCollection;
		}

		public IServiceCollection AddTransient<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class {
			_serviceCollection.AddTransient(implementationFactory);
			return _serviceCollection;
		}

		public IServiceCollection AddTransient<TService, TImplementation>()
			where TService : class
			where TImplementation : class, TService {
			_serviceCollection.AddTransient<TService, TImplementation>();
			return _serviceCollection;
		}

		public IServiceCollection AddTransient<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
			where TService : class
			where TImplementation : class, TService {
			_serviceCollection.AddTransient(implementationFactory);
			return _serviceCollection;
		}
	}
}
