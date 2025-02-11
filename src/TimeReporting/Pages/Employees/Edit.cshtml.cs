using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

[Authorize(Roles = "Admin")]
public class Edit(IAppDbContext db) : PageModel
{
    [BindProperty]
    public Employee Employee { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        this.SetTitle("Edit Employee");

        try
        {
            var employee = await db.Users.FirstOrDefaultAsync(e => e.Id == id);

            if (employee is null)
            {
                this.SendNotification(NotificationType.Danger, "Employee not found.");
                return NotFound();
            }

            Employee = employee;
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
            return NotFound();
        }

        return Page();
    }
}