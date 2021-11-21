var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Map HTTP GET
app.MapGet("/", () => "Hello World!");

// Terminal (last) middleware
app.Run();
