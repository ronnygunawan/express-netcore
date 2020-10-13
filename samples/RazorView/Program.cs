using ExpressNetCore;

ExpressApp app = new ExpressApp(args);

app.MapGet("/", context => context.Response.RenderAsync("Home/Index"));
app.MapGet("/about", context => context.Response.RenderAsync("Home/About"));

app.Run();
