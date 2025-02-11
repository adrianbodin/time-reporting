using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

[Authorize(Roles = "Admin")]
public class DetailsModel(IAppDbContext db) : PageModel
{
    public EmployeeDetailsDto Employee { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employee = await db.Users
            .AsNoTracking()
            .Where(e => e.Id == id)
            .Select(e => new EmployeeDetailsDto(
                e.Id,
                e.FullName,
                e.Email,
                e.PhoneNumber,
                e.HireDate,
                e.JobTitle,
                e.TimeEntries
                    .OrderByDescending(t => t.Date)
                    .Take(5)
                    .Select(t => new TimeEntryDetailsDto(
                        t.Project.Name,
                        t.Hours,
                        t.Date,
                        t.WorkType.Name
                    ))
                    .ToList()
            ))
            .FirstOrDefaultAsync();

        if (employee is null)
        {
            this.SendNotification(NotificationType.Danger, "Employee not found.");
            return NotFound();
        }

        Employee = employee;

        return Page();
    }
}