# ASPEX - Express-style wrapper for Asp.Net Core

### Hello World

```cs
var app = new ExpressApp();
app.MapGet("/", ctx => ctx.Response.WriteAsync("Hello world!!"));
app.Run();
```

### Method-level Dependency Injection
```cs
app.AddTransient<IService, Service>();
app.MapGet("/students/{name}", (HttpResponse res, IService svc, string name) =>
    res.WriteJsonAsync(svc.GetStudent(name))
);
app.MapPost("/students", async (HttpResponse res, IService svc, AddStudentPayload body) => {
    await svc.AddStudentAsync(body.Name, body.Address);
    res.StatusCode = 201;
});
```

### Render Razor View
```cs
app.MapGet("/students/{name}", (HttpResponse res, IService svc, string name) =>
    res.RenderRazorViewAsync("Students/Profile", svc.GetStudent(name))
);
```

### Routers
```cs
app.MapRouter<StudentsRouter>("students");

public class StudentsRouter {
    private readonly IService _service;

    public StudentsRouter(IService service) {
        _service = service;
    }

    [MapGet("{name}")]
    public async Task GetStudent(HttpResponse res, string name) {
        res.RenderRazorViewAsync("Students/Profile", _service.GetStudent(name));
    }
}
```

### This project is a work in progress
Currently being developed:
- [x] ~~Rendering Razor views and Razor pages~~
- [ ] Middleware, WebSocket, Server Error Page, and 404 Page
- [x] ~~React support~~
- [ ] Blazor support
- [x] ~~Entity Framework support~~
- [ ] Authentication and Authorization for idiots
- [ ] Visual Studio project template
