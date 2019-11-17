# Hello World

```cs
var app = new WebApp();
app.MapGet("/", ctx => ctx.Response.WriteAsync("Hello world."));
app.Run();
```
