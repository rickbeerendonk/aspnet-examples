var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new List<string> { "one", "two", "three" });

app.Run();
