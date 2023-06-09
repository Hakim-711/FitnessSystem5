using FitnessSystem.Areas.Identity.Data;
using FitnessSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FitnesSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FitnesSystemContext") ?? throw new InvalidOperationException("Connection string 'FitnesSystemContext' not found.")));
builder.Services.AddDbContext<FitnessSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FitnessSystemContextConnection") ?? throw new InvalidOperationException("Connection string 'FitnessSystemContextConnection' not found.")));

builder.Services.AddDefaultIdentity<FitnessSystemUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<FitnessSystemContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
 
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


app.MapRazorPages();
app.Run();
