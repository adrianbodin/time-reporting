using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Anstallda;

[Authorize(Roles = "Admin")]
public class RedigeraModel(IAppDbContext db) : PageModel
{
    [BindProperty] public EditEmployeeDto Employee { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        this.SetTitle("Edit Employee");

        try
        {
            var employee = await db.Users
                .Where(u => u.Id == id)
                .Select(e => new EditEmployeeDto
                {
                    Id = e.Id,
                    FullName = e.FullName,
                    JobTitle = e.JobTitle,
                    PhoneNumber = e.PhoneNumber,
                    HireDate = e.HireDate.ToDateTime(TimeOnly.MinValue)
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();

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

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        var employee = await db.Users.FindAsync(Employee.Id);

        var fullNameExists =
            await db.Users.AnyAsync(e => e.FullName.ToLower() == Employee.FullName.ToLower() && e.Id != Employee.Id);
        if (fullNameExists)
        {
            ModelState.AddModelError("Employee.FullName", "An employee with this name already exists.");
            Response.StatusCode = StatusCodes.Status409Conflict;
            return Page();
        }

        if (employee is null)
        {
            this.SendNotification(NotificationType.Danger, "Employee not found.");
            return NotFound();
        }

        employee.FullName = Employee.FullName;
        employee.JobTitle = Employee.JobTitle;
        employee.PhoneNumber = Employee.PhoneNumber;
        employee.HireDate = DateOnly.FromDateTime(Employee.HireDate);

        await db.SaveChangesAsync();

        this.SendNotification(NotificationType.Success,
            $"The employee \"{employee.FullName}\" was updated successfully");

        return RedirectToPage("./Index");
    }
}