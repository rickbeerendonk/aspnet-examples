using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

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

// TypedResult since .NET 7 
app.MapGet("/", () => TypedResults.Ok(new List<string> { "one", "two", "three" }));

app.MapGet("/fail", () => TypedResults.BadRequest());

app.Run();
