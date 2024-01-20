var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use:
// - Anonymous inline middleware.

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Use 1\n");
    await next.Invoke();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Use 2\n");
    await next.Invoke();
});

app.Run();
