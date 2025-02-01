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
    const string adminRoleName = "Admin";
    string normalizedAdminRoleName = adminRoleName.ToUpper(); // Normalized name

    // Directly query the database to check for the role
    var existingRole = await context.Roles
        .AsNoTracking()
        .FirstOrDefaultAsync(r => r.NormalizedName == normalizedAdminRoleName);

    if (existingRole == null)
    {
        // Only create the role if it doesn't exist in the database
        var roleResult = await roleManager.CreateAsync(new IdentityRole(adminRoleName));
        if (!roleResult.Succeeded)
        {
            Console.WriteLine($"Failed to create Admin role: {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
            return;
        }
    }

    const string adminEmail = "admin@example.com";
    const string adminPassword = "Admin123!";

    // Directly query the database for the admin user
    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
        adminUser = new Employee
        {
            UserName = adminEmail,
            Email = adminEmail,
            FullName = "Admin User",
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

    // Ensure the admin user is assigned to the "Admin" role
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
