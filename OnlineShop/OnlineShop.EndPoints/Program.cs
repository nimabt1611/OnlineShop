using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Contracts.Categorys;
using OnlineShop.Domain.Contracts.People;
using OnlineShop.Infrastructure.DataAccess.Common;
using OnlineShop.Infrastructure.DataAccess.People;
using OnlineShop.Infrastructure.DataAccess.Categorys;
using OnlineShop.Domain.Contracts.Products;
using OnlineShop.Infrastructure.DataAccess.Products;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
var configuration = builder.Configuration;
builder.Services.AddDbContext<OnlineShopContext>(c => c.UseSqlServer(configuration.GetConnectionString("OnlineShop")));
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductReopsitory>();



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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
