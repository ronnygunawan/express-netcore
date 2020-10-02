using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPEX.Internal {
	internal class Startup {
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services) {
			ExpressApp webApp = services
				.Select(descriptor => descriptor.ImplementationInstance)
				.OfType<ExpressApp>()
				.Single();

			foreach (Action<IConfiguration> configureServiceAction in webApp.ConfigureServiceActions) {
				configureServiceAction.Invoke(Configuration);
			}

			services.AddDatabaseDeveloperPageExceptionFilter();

			services.AddControllersWithViews()
				.AddApplicationPart(Assembly.GetEntryAssembly())
				.AddRazorRuntimeCompilation();
			services.AddRazorPages();
		}

		[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Method called by runtime")]
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			} else {
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			ExpressApp webApp = app.ApplicationServices.GetRequiredService<ExpressApp>();
			if (webApp.UseHttpsRedirection) {
				app.UseHttpsRedirection();
			}
			app.UseStaticFiles();
			if (webApp.SpaSettings.Count > 0) {
				app.UseSpaStaticFiles();
			}

			app.UseRouting();

			app.UseAuthentication();
			if (webApp.UseIdentityServer) {
				app.UseIdentityServer();
			}
			app.UseAuthorization();

			app.UseRouter(routeBuilder => {
				foreach (Action<IRouteBuilder> setupAction in webApp.RouteSetupActions) {
					setupAction.Invoke(routeBuilder);
				}
			});

			app.UseEndpoints(endpoints => {
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});

			foreach ((string sourcePath, string devServerNpmScript) in webApp.SpaSettings) {
				app.UseSpa(spa => {
					spa.Options.SourcePath = sourcePath;

					if (env.IsDevelopment()) {
						spa.UseReactDevelopmentServer(npmScript: devServerNpmScript);
					}
				});
			}
		}
	}
}
