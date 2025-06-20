using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using RoomManagerMVCApp.Data;
using RoomManagerMVCApp.Infra;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient<CustomExceptionMiddleware>();
// Add services to the container.

builder.Services.AddTransient<ErrorHandlerMiddleware>();

builder.Services.AddControllersWithViews();/* opts =>
{
    opts.Filters.Add(new MyExceptionFilter());
});*/

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(copts =>
    {
        copts.LoginPath = "/Account/Login";       
    });

builder.Services.AddAuthorization(cfg =>
{
    cfg.AddPolicy("OnlyAdmin", pol =>
    {
        pol.RequireClaim(ClaimTypes.Role, "Admin");
    });
});
builder.Services.AddSession();
builder.Services.AddLogging(bldr =>
{
    bldr.ClearProviders();
    bldr.AddConsole();
    bldr.SetMinimumLevel(LogLevel.Error);
});

builder.Services.AddHttpLogging();
string sqlConString=builder.Configuration.GetConnectionString("DbCon");

builder.Services.AddDbContext<RoomManagerDbContext>(cfg =>
{
    cfg.UseSqlServer(sqlConString);
});

var app = builder.Build();
//app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseSession();
app.UseHttpLogging();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AddRoom}/{action=ViewRooms}/{id?}")
    .WithStaticAssets();

app.Run();
