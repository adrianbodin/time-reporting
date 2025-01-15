using Microsoft.AspNetCore.Identity;
using TimeReporting.Models;

namespace TimeReporting.Data;

public static class SeedData
{
    public static async Task SeedRolesAndAdminUserAsync(
        AppDbContext context,
        RoleManager<IdentityRole> roleManager,
        UserManager<Employee> userManager)
    {
        // Ensure the database is created
        await context.Database.EnsureCreatedAsync();

        // Ensure the "Admin" role exists
        const string adminRoleName = "Admin";
        if (!await roleManager.RoleExistsAsync(adminRoleName))
        {
            var roleResult = await roleManager.CreateAsync(new IdentityRole(adminRoleName));
            if (!roleResult.Succeeded)
            {
                Console.WriteLine("Failed to create Admin role.");
                return;
            }
        }

        const string adminEmail = "admin@example.com";
        const string adminPassword = "Admin123!";

        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new Employee
            {
                UserName = adminEmail,
                Email = adminEmail,
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
