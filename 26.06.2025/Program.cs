using BookMyShowAPI.Data;
using BookMyShowAPI.Helper;
using BookMyShowAPI.Interfaces;
using BookMyShowAPI.Services;
using Microsoft.EntityFrameworkCore.SqlServer;
using BookMyShowAPI.Repository.Interfaces;
using BookMyShowAPI.DTO;
using Microsoft.EntityFrameworkCore;
using BookMyShowAPI.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure EF Core with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();

// Register Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IReviewService, ReviewService>();

// Register Helper Services
builder.Services.AddSingleton<IOTPService, OTPService>();
builder.Services.AddSingleton<ICaptchaService, CaptchaService>();

// Configure the HTTP request pipeline
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();