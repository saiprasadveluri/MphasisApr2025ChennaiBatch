using Microsoft.EntityFrameworkCore;
using RideAggregatorWEBAPI;
using RideAggregatorWEBAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var config=builder.Configuration;
builder.Services.AddDbContext<RideDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("Dbcon"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
