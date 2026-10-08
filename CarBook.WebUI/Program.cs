using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

// 1. COOKIE AUTHENTICATION (builder.Build() satırından önce olmalı)
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, opt =>
    {
        opt.LoginPath = "/Login/Index/";
        opt.LogoutPath = "/Login/LogOut/";
        opt.AccessDeniedPath = "/Error/Index/";
        opt.Cookie.HttpOnly = true;
        opt.Cookie.Name = "CarBookJwtCookie";
    });

var app = builder.Build(); // Servis tanımlamaları bu satırdan ÖNCE bitmelidir!

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// 2. KİMLİK DOĞRULAMA MIDDLEWARE'LERİ (Sıralama önemli)
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

// AREA ROUTE
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// DEFAULT ROUTE
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();