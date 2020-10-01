using ASPEX;

AspexApp app = new AspexApp(args);

app.MapGet("/", context => context.Response.RenderRazorViewAsync("Home/Index"));
app.MapGet("/about", context => context.Response.RenderRazorViewAsync("Home/About"));

app.Run();
