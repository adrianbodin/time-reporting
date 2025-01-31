using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Models;

namespace TimeReporting.Data;

public static class SeedData
{
    public static async Task SeedRolesAndAdminUserAsync(
        AppDbContext context,
        RoleManager<IdentityRole> roleManager,
        UserManager<Employee> userManager)
    {
        // Make sure no duplicate entries exist
        const string adminRoleName = "Admin";
        var existingRole = await context.Roles.FirstOrDefaultAsync(r => r.NormalizedName == adminRoleName.ToUpper());

        if (existingRole == null)
        {
            var roleResult = await roleManager.CreateAsync(new IdentityRole(adminRoleName));
            if (!roleResult.Succeeded)
            {
                Console.WriteLine($"Failed to create Admin role: {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
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
                PhoneNumber = "0987654321",
                FullName = "Admin",
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
