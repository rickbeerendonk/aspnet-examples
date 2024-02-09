// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// 2. Use Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Use Swagger
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
