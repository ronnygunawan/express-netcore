using ExpressNetCore;

ExpressApp app = new ExpressApp(args);

app.MapGet("/", context => context.Response.RenderRazorViewAsync("Home/Index"));
app.MapGet("/about", context => context.Response.RenderRazorViewAsync("Home/About"));

app.Run();
