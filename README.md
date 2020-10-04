[![NuGet](https://img.shields.io/nuget/v/RG.ExpressNetCore.svg)](https://www.nuget.org/packages/RG.ExpressNetCore/)

# ExpressNetCore - Express-style wrapper for Asp.Net Core

Here's a fully working ASP.NET Core Web Application written in only a few lines of code using ExpressNetCore:

![screenshot.png](https://raw.githubusercontent.com/ronnygunawan/express-netcore/master/screenshot.png)

## Installation
Prerequisites:
- [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)

Creating new project:
- From `Create a new project` window select `ASP.NET Core Web Application`
- Enter project name
- Select `ASP.NET Core 5.0` target framework, and `Empty` project type
- In the newly created project, type following command in `Package Manager Console`:
```
Install-Package RG.ExpressNetCore
```

## Hello World

```cs
var app = new ExpressApp();
app.MapGet("/", ctx => ctx.Response.WriteAsync("Hello world!!"));
app.Run();
```

## Routing

```cs
app.MapDelete("/", ctx => ctx.Response.StatusCode = 204);
app.MapGet("/", ctx => ctx.Response.WriteAsync("Hello world!!"));
app.MapPost("/", (HttpContext ctx, Payload body) => ctx.Response.WriteAsync($"Hello {body.Name}!!"));
app.MapPut("/", ctx => ctx.Response.WriteAsync("Hello world!!"));
app.MapVerb("HEAD", "/", ctx => ctx.Response.WriteAsync("Hello world!!"));
```

## Method-level Dependency Injection

Any specified lambda parameters will be resolved using Dependency Injection

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

### Available dependencies

#### 1. Any registered services

```cs
// Register services
app.AddTransient<IStudentRepository, StudentRepository>();
app.AddTransient<ILogger, Logger>();

// Use registered services in lambda arguments. They will be automatically resolved.
app.MapPost("/students", async (HttpResponse res, IStudentRepository repo, ILogger logger, AddStudentPayload body) => {
    await repo.AddStudentAsync(body.Name, body.Address);
	logger.Log("Student added");
	res.StatusCode = 201;
});
```

#### 2. Route parameters

```cs
// a and b will be resolved as route parameters with same name
app.MapGet("/add/{a}/{b}", (HttpResponse res, int a, int b) => res.WriteAsync($"{a + b}"));
```

#### 3. Query strings

```cs
// a and b will be resolved as query strings with same name
// eg. /add?a=1&b=2
app.MapGet("/add", (HttpResponse res, int a, int b) => res.WriteAsync($"{a + b}"));
```

#### 4. Request body (parameter must be named `body`)

```cs
app.MapPost("/add", (HttpResponse res, AddPayload body) => res.WriteAsync($"{body.A + body.B}"));
```

#### 5. Request form (parameter must be of type `IFormCollection`)

```cs
app.MapPost("/add", (HttpResponse res, IFormCollection form) => res.WriteAsync($"You uploaded {form.Files.Count} files."));
```

#### 6. `HttpContext`, `HttpRequest`, `HttpResponse`, and `CancellationToken`

## Render Razor View
```cs
app.MapGet("/students/{name}", (HttpResponse res, IService svc, string name) =>
    res.RenderRazorViewAsync("Students/Profile", svc.GetStudent(name))
);
```

## Routers

Works similar to MVC Controllers, but with method-level dependency injection

```cs
app.MapRouter<StudentsRouter>("/students");

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

## Hosting React SPA

Create a new folder containing your React app using `npx create-react-app ClientApp`, then configure your web app:

```cs
app.AddSpa(sourcePath: "ClientApp", buildPath: "ClientApp/build", devServerNpmScript: "start");
```
