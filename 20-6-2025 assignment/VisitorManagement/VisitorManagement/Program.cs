using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VisitorManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication
    (CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(copts =>
    {
        copts.LoginPath = "/Account/Login";

    });

string sqlbiulder = builder.Configuration.GetConnectionString("DbCon");
builder.Services.AddDbContext<VisitorManagementContext>(cfg =>
{
    cfg.UseSqlServer(sqlbiulder);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=VisitorManger}/{action=VisitorView}/{id?}")
    .WithStaticAssets();


app.Run();
