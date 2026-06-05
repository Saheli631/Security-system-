using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// ---------------- SERVICES ----------------
builder.Services.AddControllersWithViews();

// DB Context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// SESSION (IMPORTANT)
builder.Services.AddSession();

// ---------------- BUILD APP ----------------
var app = builder.Build();

// ---------------- PIPELINE ----------------
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// ?? IMPORTANT: SESSION MIDDLEWARE (YOU WERE MISSING THIS)
app.UseSession();

app.UseAuthorization();

// ---------------- ROUTES ----------------
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();