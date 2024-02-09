// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new List<string> { "one", "two", "three" });

app.Run();
