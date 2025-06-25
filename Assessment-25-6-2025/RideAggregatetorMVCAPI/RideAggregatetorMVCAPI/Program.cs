using Microsoft.EntityFrameworkCore;
using RideAggregatetorMVCAPI.DataAccess;
using RideAggregatetorMVCAPI.DTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<DataAccessLayer>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
string sqlbiulder = builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<RideContext>(cfg =>
{
    cfg.UseSqlServer(sqlbiulder);
});

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
