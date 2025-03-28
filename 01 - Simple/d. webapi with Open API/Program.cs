// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

string[] technologies = ["ASP.NET Core", "Visual Basic", "C#", "F#", "Q#", "Entity Framework", "SignalR"];

app.MapGet("/technologies", () => technologies).WithName("GetTechnologies");

app.Run();
