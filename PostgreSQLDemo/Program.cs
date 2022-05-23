using Microsoft.EntityFrameworkCore;
using PostgreSQLDemo;
using PostgreSQLDemo.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//PostgreSQL provider added
builder.Services.AddDbContext<DataContext>(o => o.UseNpgsql(Config.ConnectionString));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles().UseRouting().UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Seed();

app.Run();
