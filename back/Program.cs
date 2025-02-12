using back.Data;
using back.Configurations; // Import the SwaggerConfig class
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<Db>();
builder.Services.AddDbContextPool<Db>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Add Swagger services
builder.Services.AddSwaggerServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // This will not be necessary for HTTP-only setup.
}

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
