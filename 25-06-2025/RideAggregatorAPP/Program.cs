using Microsoft.EntityFrameworkCore;
using RideAggregatorAPP.Data;
using RideAggregatorAPP.Services;
using RideAggregatorAPP.Services.Service;
using RideAggregatorAPP.Data;
using RideAggregatorAPP.Services;
using RideAggregatorAPP.Services.Service;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddScoped<IRideService, RideService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddDbContext<RideDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddDbContext<RideDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();