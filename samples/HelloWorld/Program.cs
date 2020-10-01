using ASPEX;
using Microsoft.AspNetCore.Http;

AspexApp app = new AspexApp(args);

app.MapGet("/", context => context.Response.WriteAsync("Hello world."));

app.Run();
