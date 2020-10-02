using ASPEX;
using Microsoft.AspNetCore.Http;

ExpressApp app = new ExpressApp(args);

app.MapGet("/", context => context.Response.WriteAsync("Hello world."));

app.Run();
