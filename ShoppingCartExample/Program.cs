using Microsoft.EntityFrameworkCore;
using ShoppingCartExample.Data;
using ShoppingCartExample.Services;

var builder = WebApplication.CreateBuilder(args);
var configurationManager = builder.Configuration;

// Add services to the container.
builder.Services
       .AddControllersWithViews()
       .AddRazorRuntimeCompilation();

builder.Services
       .AddScoped<IProductService, ProductService>()
       .AddScoped<IProductRepository, ProductRepository>();

builder.Services
       .AddScoped<ICustomerRepository, CustomerRepository>()
       .AddScoped<ICustomerService, CustomerService>();

builder.Services
       .AddScoped<IOrderRepository, OrderRepository>()
       .AddScoped<IOrderService, OrderService>();

builder.Services
       .AddDbContext<Database>(options => options.UseSqlServer(configurationManager["ConnectionStrings:Main"]));

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
