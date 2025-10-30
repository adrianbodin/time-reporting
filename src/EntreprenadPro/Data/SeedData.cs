using EntreprenadPro.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Data;

public static class SeedData
{
   public static async Task SeedRolesAndAdminUserAsync(
    AppDbContext context,
    RoleManager<IdentityRole> roleManager,
    UserManager<Employee> userManager)
{
    const string adminRoleName = "Admin";
    string normalizedAdminRoleName = adminRoleName.ToUpper();

    var existingRole = await context.Roles
        .AsNoTracking()
        .FirstOrDefaultAsync(r => r.NormalizedName == normalizedAdminRoleName);

    if (existingRole is null)
    {
        var roleResult = await roleManager.CreateAsync(new IdentityRole(adminRoleName));
        if (!roleResult.Succeeded)
        {
            Console.WriteLine($"Failed to create Admin role: {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
            return;
        }
    }

    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
    {
        const string adminEmail = "admin@example.com";
        const string adminPassword = "Admin123!";

        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new Employee
            {
                UserName = adminEmail,
                Email = adminEmail,
                FullName = "Admin User",
                HireDate = DateOnly.FromDateTime(DateTime.Now),
                JobTitle = "Administrator",
                PhoneNumber = "1234567890",
                EmailConfirmed = true
            };

            var userResult = await userManager.CreateAsync(adminUser, adminPassword);
            if (!userResult.Succeeded)
            {
                Console.WriteLine($"Failed to create Admin user: {string.Join(", ", userResult.Errors.Select(e => e.Description))}");
                return;
            }
        }

        if (!await userManager.IsInRoleAsync(adminUser, adminRoleName))
        {
            var roleAssignResult = await userManager.AddToRoleAsync(adminUser, adminRoleName);
            if (!roleAssignResult.Succeeded)
            {
                Console.WriteLine($"Failed to assign Admin role: {string.Join(", ", roleAssignResult.Errors.Select(e => e.Description))}");
            }
        }
    }
}

}
