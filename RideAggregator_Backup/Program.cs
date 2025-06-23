using Microsoft.EntityFrameworkCore;
using RideAggregatorAPI.Data;
using RideAggregatorAPI.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var Config = builder.Configuration;
builder.Services.AddDbContext<RideDBContext>(opts =>
{
    opts.UseSqlServer(Config.GetConnectionString("DbCon"));
});
builder.Services.AddTransient<DbAccess>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
