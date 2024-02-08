// European Union Public License version 1.2
// Copyright © 2021 Rick Beerendonk

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Open: https://localhost:5000/index.html
app.UseStaticFiles();

app.Run();
