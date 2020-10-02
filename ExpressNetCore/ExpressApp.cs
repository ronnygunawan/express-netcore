using System;
using System.Collections.Generic;
using System.IO;
using ExpressNetCore.Internal;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExpressNetCore {
	public partial class ExpressApp {
		private readonly string[]? _args;
		private readonly IServiceCollection _serviceCollection;
		private string[]? _urls;
		private string? _contentRoot;
		private string? _environment;

		internal List<Action<IConfiguration>> ConfigureServiceActions { get; }
		internal List<Action<IRouteBuilder>> RouteSetupActions { get; }

		public bool UseHttpsRedirection { get; set; } = true;

		public ExpressApp(string[]? args = null) {
			_args = args;
			_serviceCollection = new ServiceCollection();
			_serviceCollection.AddSingleton(this);
			ConfigureServiceActions = new List<Action<IConfiguration>>();
			RouteSetupActions = new List<Action<IRouteBuilder>>();
		}

		public ExpressAppRouter this[string route] => new ExpressAppRouter(this, route);

		public ExpressApp ConfigureServices(Action<IConfiguration> configureServiceAction) {
			ConfigureServiceActions.Add(configureServiceAction);
			return this;
		}

		public ExpressApp UseUrls(params string[] urls) {
			_urls = urls;
			return this;
		}

		public ExpressApp UseContentRoot(string contentRoot) {
			_contentRoot = contentRoot;
			return this;
		}

		public ExpressApp UseEnvironment(string environment) {
			_environment = environment;
			return this;
		}

		public void Run() {
			Host.CreateDefaultBuilder(_args ?? Array.Empty<string>())
				.ConfigureServices(serviceCollection => {
					foreach (ServiceDescriptor serviceDescriptor in _serviceCollection) {
						serviceCollection.Add(serviceDescriptor);
					}
				})
				.ConfigureWebHostDefaults(webBuilder => {
					if (_urls != null) {
						webBuilder.UseUrls(_urls);
					}
					if (_contentRoot != null) {
						webBuilder.UseContentRoot(_contentRoot);
					} else {
						webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
					}
					if (_environment != null) {
						webBuilder.UseEnvironment(_environment);
					}
					webBuilder.UseStartup<Startup>();
				})
				.Build()
				.Run();
		}
	}
}
