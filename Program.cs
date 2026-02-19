using ApplicationFormApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add MVC
builder.Services.AddControllersWithViews();


// ================= DATABASE CONNECTION =================

// Render environment variable
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

// Local fallback (so project still runs on your laptop)
if (string.IsNullOrWhiteSpace(connectionString))
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
}

// Final safety check
if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new Exception("Database connection string is missing. Set DB_CONNECTION in Render.");
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


// ================= BUILD APP =================
var app = builder.Build();


// ================= APPLY MIGRATIONS (IMPORTANT FOR RENDER) =================
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    // This creates DB tables automatically if not exists
    db.Database.Migrate();
}


// ================= MIDDLEWARE =================
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ApplicationForm}/{action=Create}/{id?}");

app.Run();
