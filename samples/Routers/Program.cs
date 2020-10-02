using System.Net.Http;
using ExpressNetCore;
using Microsoft.AspNetCore.Http;
using Routers.Routers;
using Routers.Services;

ExpressApp app = new ExpressApp(args);

app.AddSingleton<HttpClient>();
app.AddMemoryCache();
app.AddTransient<DekontaminasiClient>();

app.MapGet("/", (HttpResponse res) => res.RenderRazorViewAsync("Home/Index"));
app.MapRouter<Covid19Router>("/covid19");

app.Run();
