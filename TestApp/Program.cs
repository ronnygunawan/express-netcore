using System;
using System.Linq;
using System.Threading;
using ASPEX;
using Microsoft.AspNetCore.Http;

namespace TestApp {
	class Program {
		static void Main(string[] args) {
			WebApp app = new WebApp(args);
			app.AddTransient<Logger>();
			app.AddTransient<Reverser>();
			app.MapGet("/", context => context.Response.WriteAsync("Welcome to ASP.NET for idiots."));
			app.MapGet("/idiot/{id:int}", (HttpResponse res, int id) => res.WriteAsync($"Hello, idiot #{id}! You're an idiot."));
			app.MapGet("/hello/{name}", (HttpResponse res, string name) => res.WriteAsync($"Hello, {name}! You're an idiot."));
			app.MapGet("/hello/{name}/reverse", (HttpResponse res, string name, Reverser rev, CancellationToken cancellationToken) => res.WriteAsync($"Hello, {rev.ReverseName(name)}! You're an idiot.", cancellationToken));
			app.MapPost("/", (HttpResponse res, Payload body) => res.WriteAsync($"You posted {body.Name}."));
			app.MapGet("/razor", context => context.Response.RenderRazorViewAsync("Razor/Index", null));
			app.Run();
		}

		class Reverser {
			private readonly Logger _logger;

			public Reverser(Logger logger) {
				_logger = logger;
			}

			public string ReverseName(string name) {
				_logger.Log(name);
				return new string(name.Reverse().ToArray());
			}
		}

		class Logger {
			public void Log(string message) {
				Console.WriteLine(message);
			}
		}

		class Payload {
			public string Name { get; set; }
		}
	}
}
