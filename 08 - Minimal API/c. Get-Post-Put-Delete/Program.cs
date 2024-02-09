// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

int nextId = 0;
int getId() => nextId++;

Dictionary<int, string> collection = new() { { getId(), "one" }, { getId(), "two" }, { getId(), "three" } };

app.MapGet("/", () => collection.Values);

app.MapGet("/{id}", Results<Ok<string>, NotFound> (int id) => collection.TryGetValue(id, out string? value) ? TypedResults.Ok(value) : TypedResults.NotFound()).WithName("OneValue");

app.MapPost("/", Results<CreatedAtRoute<string>, BadRequest> (string value) =>
{
  if (value == null)
  {
    return TypedResults.BadRequest();
  }
  int id = getId();
  collection.Add(id, value);
  return TypedResults.CreatedAtRoute<string>(value, "OneValue", new { id });
});

app.MapPut("/{id}", Results<NoContent, BadRequest, NotFound> (int id, string value) =>
{
  if (value == null)
  {
    return TypedResults.BadRequest();
  }

  if (!collection.ContainsKey(id))
  {
    return TypedResults.NotFound();
  }

  collection[id] = value;
  return TypedResults.NoContent();
});

app.MapDelete("/{id}", Results<NoContent, NotFound> (int id) =>
{
  if (collection.Remove(id))
  {
    return TypedResults.NoContent();
  }
  else
  {
    return TypedResults.NotFound();
  }
});

app.Run();
