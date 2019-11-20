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
app.MapGet("/", (HttpResponse res, IService svc) => res.WriteAsync(svc.GetValue());
```

### Route values as lambda parameter
```cs
app.MapGet("/people/{name}", (HttpResponse res, string name) => res.WriteJsonAsync(new {
    Name = name
}));
```

### Request body as lambda parameter
```cs
app.MapPost("/", (HttpResponse res, Payload body) => res.WriteAsync(body.Name));
```

### Combined path
```cs
app["home"].Map(home => {
    home.MapGet("", ctx => ctx.Response.WriteAsync("Welcome home."));
	home.MapGet("{name}", (HttpResponse res, string name) => res.WriteAsync($"Welcome home, {name}."));
});
```

### Mapping routes in separate classes
```cs
app.Map(root => RootRoutes.Map(root));
app["home"].Map(home => HomeRoutes.Map(home));
```

### MVC and Razor Pages
Just add `Controllers` and `Views` folders for MVC, or `Pages` for Razor Pages to the project.

### Static files
Just add `wwwroot` folder to the project.
