using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

public record EmployeeDetailsDto(
    string Id,
    string FullName,
    string Email,
    string PhoneNumber,
    DateOnly? HireDate,
    string JobTitle,
    List<TimeEntryDetailsDto> RecentTimeEntries
);

public record TimeEntryDetailsDto(
    string ProjectName,
    double Hours,
    DateOnly Date,
    string WorkType
);

[Authorize(Roles = "Admin")]
public class DetailsModel : PageModel
{
    private readonly AppDbContext _db;

    public DetailsModel(AppDbContext db)
    {
        _db = db;
    }

    public EmployeeDetailsDto? Employee { get; set; }

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employee = await _db.Users
            .Include(e => e.TimeEntries)
                .ThenInclude(t => t.Project)
            .Include(e => e.TimeEntries)
                .ThenInclude(t => t.WorkType)
            .FirstOrDefaultAsync(e => e.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        Employee = new EmployeeDetailsDto(
            employee.Id,
            employee.FullName,
            employee.Email,
            employee.PhoneNumber,
            employee.HireDate,
            employee.JobTitle ?? "Not Assigned",
            employee.TimeEntries
                .OrderByDescending(t => t.Date)
                .Take(5)
                .Select(t => new TimeEntryDetailsDto(
                    t.Project.Name,
                    t.Hours,
                    t.Date,
                    t.WorkType.Name
                ))
                .ToList()
        );

        return Page();
    }
}