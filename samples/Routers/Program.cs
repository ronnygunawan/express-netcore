using System.Net.Http;
using ASPEX;
using Microsoft.AspNetCore.Http;
using Routers.Routers;
using Routers.Services;

AspexApp app = new AspexApp(args);

app.AddSingleton<HttpClient>();
app.AddTransient<DekontaminasiClient>();

app.MapGet("/", (HttpResponse res) => res.RenderRazorViewAsync("Home/Index"));
app.MapRouter<Covid19Router>("/covid19");

app.Run();
