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
public class IndexModel(IAppDbContext db) : PageModel
{
    public IEnumerable<EmployeeTableDto> Employees { get; set; } = null!;

    public async Task<IActionResult> OnGet()
    {
        this.SetTitle("All Employees");

        try
        {
            var employees = await db.Users
                .AsNoTracking()
                .Select(e => new EmployeeTableDto(e.Id, e.FullName, e.JobTitle, DateTime.Parse(e.HireDate.ToString())))
                .ToListAsync();

            Employees = employees;
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
            return Page();
        }

        return Page();
    }
}