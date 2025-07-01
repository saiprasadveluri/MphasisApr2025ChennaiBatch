using Microsoft.EntityFrameworkCore;
using OnlinePharmacyAppAPI.Model;
using OnlinePharmacyAppAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var Config = builder.Configuration;
builder.Services.AddDbContext<OPADBContext>(opts =>
{
    opts.UseSqlServer(Config.GetConnectionString("SqlServerConnection"));
});
//builder.Services.AddTransient<DBAccess>();

builder.Services.AddTransient<Unity>();
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
