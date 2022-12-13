var builder = WebApplication.CreateBuilder(args);

// 1. Use Controllers
builder.Services.AddControllers();

var app = builder.Build();

// 2. Use Controllers
app.MapControllers();

app.Run();
