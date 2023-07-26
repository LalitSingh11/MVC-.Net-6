using Microsoft.EntityFrameworkCore;
using BHI.SalesArchitect.Model.DB;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.LoginPath = "/Account/Login"; // Set the login page URL
            options.LogoutPath = "/Account/Logout"; // Set the logout page URL
        });

var config = builder.Configuration.AddJsonFile("appsettings.json").Build();
builder.Services.AddDbContext<SalesArchitectContext>(options =>
        options.UseSqlServer(config.GetSection("ConnectionString").Value), ServiceLifetime.Transient);


var app = builder.Build();

app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
