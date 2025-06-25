using Microsoft.EntityFrameworkCore;
using RideAggregators.Data;
using RideAggregators.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOptions();
string sqlBuilder = builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<RideDBContext>(cfg =>
{
    cfg.UseSqlServer(sqlBuilder);
});

builder.Services.AddTransient<DbAccess>();
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
