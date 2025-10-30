using EntreprenadPro.Extensions;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntreprenadPro.Pages.Anstallda;

[Authorize(Roles = "Admin")]
public class SkapaModel(UserManager<Employee> userManager) : PageModel
{
    [BindProperty(SupportsGet = true)] public AddEmployeeDto Employee { get; set; } = null!;

    public IActionResult OnGet()
    {
        Employee.HireDate = DateOnly.FromDateTime(DateTime.Now);

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

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
                this.SendNotification(NotificationType.Danger, "Det blev ett fel vid skapandet av den anställda.");

                return Page();
            }

            this.SendNotification(NotificationType.Success, "Den anställda har skapats.");
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "Det blev ett fel, vänligen försök igen.");
        }

        return Redirect("/Anstallda");
    }
}