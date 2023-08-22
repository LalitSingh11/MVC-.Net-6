using Microsoft.EntityFrameworkCore;
using BHI.SalesArchitect.Model.DB;
using Microsoft.AspNetCore.Authentication.Cookies;
using BHI.SalesArchitect.DependencyResolver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = "SalesArchitect.Session";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.Cookie = new CookieBuilder
            {
                HttpOnly = true,
                Name = "SalesArch.Security.Cookie",
                //Path = "/",
                SameSite = SameSiteMode.Lax,
                SecurePolicy = CookieSecurePolicy.SameAsRequest
            };
            options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            options.LoginPath = "/Account/Index"; 
            options.LogoutPath = "/Account/Logout";
            options.SlidingExpiration = true;
        });

var config = builder.Configuration.AddJsonFile("appsettings.json").Build();

builder.Services.AddDbContext<SalesArchitectContext>(options =>
        options.UseSqlServer(config.GetSection("ConnectionString").Value), ServiceLifetime.Transient);

//builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
RepositoryDependencies repositoryDependencyResolver = new(builder.Services);
ServiceDependencies servicesDependencyResolver = new(builder.Services);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Account/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseMiddleware<BHI.SalesArchitect.WebAdmin.Helpers.ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//app.UseCors();


app.UseAuthentication();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Communities}/{action=Index}/{id?}");

app.Run();
