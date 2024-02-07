// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use:
// - Anonymous inline middleware.

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Use 1\n");
    await next.Invoke();
});

// Run:
// - Anonymous inline terminal middleware.
// - Ends the app pipeline and isn't able to call next middleware.
app.Run(async context =>
{
    await context.Response.WriteAsync("Run\n");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Use 2\n");
    await next.Invoke();
});

app.Run();