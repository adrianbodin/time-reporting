using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Reports;

[Authorize]
public class Index(IAppDbContext db) : PageModel
{
    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateTime SelectedDate { get; set; }

    public List<ReadTimeEntryDto> TimeEntries { get; set; }

    public List<Customer> Customers { get; set; }

    public async Task<IActionResult> OnGet()
    {
        this.SetTitle("Reports");

        Customers = await db.Customers.ToListAsync();

        if (SelectedDate == default)
        {
            SelectedDate = DateTime.Now;
        }

        TimeEntries = await db.TimeEntries
            .Where(t => t.Date == DateOnly.FromDateTime(SelectedDate))
            .Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier).Value)
            .Select(t => new ReadTimeEntryDto(
                t.Id,
                t.Project.Name,
                t.Hours,
                t.Description,
                t.Date,
                t.WorkType.Name
            ))
            .ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPostDeleteEntry(string id)
    {
        try
        {
            var timeEntry = await db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);

            db.TimeEntries.Remove(timeEntry);
            await db.SaveChangesAsync();

            this.SendNotification(NotificationType.Success, "The time entry was removed successfully");

            TimeEntries = await db.TimeEntries
                .Where(t => t.Date == DateOnly.FromDateTime(SelectedDate))
                .Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier).Value)
                .Select(t => new ReadTimeEntryDto(
                    t.Id,
                    t.Project.Name,
                    t.Hours,
                    t.Description,
                    t.Date,
                    t.WorkType.Name
                ))
                .ToListAsync();

            return Page();
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");

            return Page();
        }

    }
}

