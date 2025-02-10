// European Union Public License version 1.2
// Copyright © 2021 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Map HTTP GET
app.MapGet("/", () => $"Hello ASP.NET Core {Environment.Version}!");

// Terminal (last) middleware
app.Run();
