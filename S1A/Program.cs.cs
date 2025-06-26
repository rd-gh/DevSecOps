using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Register all required services (including controllers)
builder.Services.AddControllers();

var app = builder.Build();

// Map controller endpoints
app.MapControllers();

app.Run();