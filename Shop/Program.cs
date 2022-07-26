using Shop.Data.Mocks;
using Shop.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Shop.Data;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Repository;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

  

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
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
app.UseMvcWithDefaultRoute();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
