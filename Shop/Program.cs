using Shop.Data.Mocks;
using Shop.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Shop.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Repository;
using System.Configuration;
using Shop.Data.Models;

var builder = WebApplication.CreateBuilder(args);

  

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddMemoryCache();
builder.Services.AddTransient<IAllCars,CarRep>();
builder.Services.AddTransient<ICarsCategory, CategoryRep>();
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("DbSetting.json", false, true).Build(); 
builder.Services.AddDbContext<AppDBContent>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles();
app.UseSession();
app.UseMvcWithDefaultRoute();
app.UseRouting();
//app.UseAuthorization();
app.UseMvc(Routes =>
{
    Routes.MapRoute(name: "default", template: "{controller-Home}/{action=Index}/{id?}");
    Routes.MapRoute(name: "categoryFilter", template: "Car/{action}/{category?}", defaults: new { Controller = "Car", action = "List" });
});

using (var scope = app.Services.CreateScope())
{

    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();

    DBObjects.Initial(content);
}
app.MapRazorPages();

app.Run();
