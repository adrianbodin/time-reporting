using Finbuckle.Html5Validation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EntreprenadPro.Data;
using EntreprenadPro.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["PostgreSql:ConnectionString"];

if(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
{
    connectionString = Environment.GetEnvironmentVariable("POSTGRESQL_CONNECTION_STRING");
}

builder.Services.AddDbContext<IAppDbContext,AppDbContext>(opt =>
    opt.UseNpgsql(connectionString));

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddHtml5Validation();

var app = builder.Build();

await using (var scope = app.Services.CreateAsyncScope())
{
    var services = scope.ServiceProvider;
    await using var context = services.GetRequiredService<AppDbContext>();
    await context.Database.EnsureCreatedAsync();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Employee>>();

    try
    {
        await SeedData.SeedRolesAndAdminUserAsync(context, roleManager, userManager);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error seeding database: {ex.Message}");
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

public partial class Program{}