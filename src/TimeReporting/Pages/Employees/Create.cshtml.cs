using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Extensions;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

[Authorize(Roles = "Admin")]
public class CreateModel(UserManager<Employee> userManager) : PageModel
{
    [BindProperty(SupportsGet = true)]
    public AddEmployeeDto Employee { get; set; } = null!;

    public IActionResult OnGet()
    {
        Employee.HireDate = DateOnly.FromDateTime(DateTime.Now);

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var user = Activator.CreateInstance<Employee>();

        try
        {
            user.FullName = Employee.FullName;
            user.Email = Employee.Email;
            user.PhoneNumber = Employee.PhoneNumber;
            user.HireDate = Employee.HireDate;
            user.JobTitle = Employee.JobTitle;
            user.UserName = Employee.Email;
            user.EmailConfirmed = true;

            var result = await userManager.CreateAsync(user, Employee.Password);

            if (!result.Succeeded)
            {
                this.SendNotification(NotificationType.Danger, "Failed to create user.");

                return Page();
            }

            this.SendNotification(NotificationType.Success, "The user was created successfully.");
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
        }

        return RedirectToPage("/Employees/Index");
    }
}