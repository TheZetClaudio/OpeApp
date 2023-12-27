using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OpeApp.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("OpeAppContextConnection") ?? throw new InvalidOperationException("Connection string 'OpeAppContextConnection' not found.");

builder.Services.AddDbContext<OpeAppContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<OpeAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<OpeAppContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
