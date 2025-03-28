// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string[] technologies = ["ASP.NET Core", "Visual Basic", "C#", "F#", "Q#", "Entity Framework", "SignalR"];

app.MapGet("/", () => technologies);

app.Run();
