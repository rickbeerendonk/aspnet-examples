// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Secret Manager");

app.Run();
