# ASPEX - Asp.Net Core Express, A wrapper for idiots

### Hello World

```cs
var app = new WebApp();
app.MapGet("/", ctx => ctx.Response.WriteAsync("Hello idiots!!"));
app.Run();
```

### Method-level Dependency Injection
```cs
app.AddTransient<IService, Service>();
app.MapGet("/idiots/{name}", (HttpResponse res, IService svc, string name) =>
    res.WriteJsonAsync(svc.GetIdiot(name))
);
app.MapPost("/idiots", async (HttpResponse res, IService svc, AddIdiotPayload body) => {
    await svc.AddAnIdiotAsync(body.Name, body.IQ);
    res.StatusCode = 201;
});
```

### MVC Controller
```cs
app.MapGet("/idiots/{name}", (HttpResponse res, IService svc, string name) =>
    res.RenderRazorViewAsync("Idiots/Profile", svc.GetIdiot(name))
);
```

### Subroutes
```cs
app["home"].Map(home => {
    home.MapGet(...);
    ...
});
```

### This project is a work in progress
Currently being developed:
- [x] ~~Rendering Razor views and Razor pages~~
- [ ] Blazor support
- [ ] Entity Framework support
- [ ] Authentication and Authorization for idiots
