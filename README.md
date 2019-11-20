# ASPEX - Asp.Net Core Express, A wrapper for idiots

### Hello World

```cs
var app = new WebApp();
app.MapGet("/", ctx => ctx.Response.WriteAsync("Hello world."));
app.Run();
```

### JSON
```cs
app.MapGet("/people/{name}", ctx => ctx.Response.WriteJsonAsync(new {
    Name = ctx.Request.RouteValues["name"]
}));
```

### Razor (WIP)
```cs
app.MapGet("/", ctx => ctx.Response.RenderRazorViewAsync("Home/Index"));
```

### Pug (Planned)
```cs
app.MapGet("/", ctx => ctx.Response.RenderPugViewAsync("index.pug"));
```

### Dependency Injection
```cs
app.AddTransient<IService, Service>();
```
