using Microsoft.EntityFrameworkCore;
using RideAggregatorAPI.Data;
using RideAggregatorAPI.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
string sqlbuilder = builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<RideDbContext>(cfg =>
{
   cfg.UseSqlServer(sqlbuilder);
});
builder.Services.AddTransient<DbAccess>();
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
