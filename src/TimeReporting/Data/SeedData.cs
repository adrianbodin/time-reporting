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

    if (!await roleManager.RoleExistsAsync(adminRoleName))
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
    if (adminUser is null)
    {
        adminUser = new Employee
        {
            UserName = adminEmail,
            Email = adminEmail,
            FullName = "Anders Admin",
            PhoneNumber = "1234567890",
            HireDate = new DateOnly(2022, 1, 1),
            EmailConfirmed = true,
            NormalizedEmail = adminEmail.ToUpper(),
        };

        var userResult = await userManager.CreateAsync(adminUser, adminPassword);
        if (!userResult.Succeeded)
        {
            Console.WriteLine($"Failed to create Admin user: {string.Join(", ", userResult.Errors.Select(e => e.Description))}");
            return;
        }
    }

    var adminHasRole = await userManager.IsInRoleAsync(adminUser, adminRoleName);

    if (!adminHasRole)
    {
        var roleAssignResult = await userManager.AddToRoleAsync(adminUser, adminRoleName);
        if (!roleAssignResult.Succeeded)
        {
            Console.WriteLine($"Failed to assign Admin role: {string.Join(", ", roleAssignResult.Errors.Select(e => e.Description))}");
        }
    }
}

}
