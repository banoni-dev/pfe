using back.Data;
using back.Configurations;
using Microsoft.EntityFrameworkCore;
using back.Services;
using back.Repositories;
using back.Auth;  // Add this for JWT service

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add JWT settings from configuration
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

// Register JWT service
builder.Services.AddSingleton<IJwtService, JwtService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<Db>();
builder.Services.AddDbContextPool<Db>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Register repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ITierRepository, TierRepository>();

// Register services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ITierService, TierService>();

// Add Swagger services
builder.Services.AddSwaggerServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // This will not be necessary for HTTP-only setup.
}

// Enable authentication middleware
app.UseMiddleware<AuthMiddleware>(); // Add the JWT auth middleware

app.UseRouting();
app.UseAuthorization();

// Enable Swagger UI
app.UseSwaggerUI();

// Map controllers and static assets
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
