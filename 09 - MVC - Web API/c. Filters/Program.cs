// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);

// 1. Use Controllers
builder.Services.AddControllers();

var app = builder.Build();

// 2. Use Controllers
app.MapControllers();

app.Run();
