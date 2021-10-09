var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use:
// - Anonymous inline middleware.

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Use 1");
    await next.Invoke();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Use 2");
    await next.Invoke();
});

// Run:
// - Anonymous inline terminal middleware.
// - Ends the app pipeline and isn't able to call next middleware.

app.Run();

/*

app.Run(async context =>
{
    await context.Response.WriteAsync("Run");
});

*/