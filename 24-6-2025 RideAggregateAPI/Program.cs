using Microsoft.EntityFrameworkCore;
using RideAggregateAPI.DataAccess;
using RideAggregateAPI.Data;
using RideAggregateAPI.DTO;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var Config = builder.Configuration;
builder.Services.AddDbContext<RADBContext>(opts =>
{
    opts.UseSqlServer(Config.GetConnectionString("SqlServerConnection"));
});
builder.Services.AddTransient<DBAccess>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();