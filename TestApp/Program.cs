using ASPEX;
using Microsoft.AspNetCore.Http;

namespace TestApp {
	class Program {
		static void Main(string[] args) {
			WebApp app = new WebApp(args);
			app.MapGet("/", context => context.Response.WriteAsync("Hello world. Welcome to ASP.NET for idiots."));
			app.MapGet("/hello/{name}", context => context.Response.WriteAsync($"Hello, {context.Request.RouteValues["name"]}! You're an idiot."));
			app.MapGet("/razor", context => context.Response.RenderRazorViewAsync("Razor/Index", null));
			app.Run();
		}
	}
}
