using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

    [BindProperty(SupportsGet = true)]
    public string SelectedProjectId { get; set; }

    public List<ReadTimeEntryDto> TimeEntries { get; set; }

    public SelectList Projects { get; set; }

    public async Task<IActionResult> OnGet()
    {
        this.SetTitle("Reports");

        var projects = await db.TimeEntries
            .Select(t => t.Project)
            .Distinct()
            .OrderBy(p => p)
            .ToListAsync();

       Projects = new SelectList(projects, "Id", "Name");

        if (SelectedDate == default)
        {
            SelectedDate = DateTime.Now;
        }

        var query = db.TimeEntries.Where(t => t.Date == DateOnly.FromDateTime(SelectedDate));

        if (!string.IsNullOrEmpty(SelectedProjectId))
        {
            query = query.Where(t => t.Project.Id == SelectedProjectId);
        }

        if (!User.IsInRole("Admin"))
        {
            query = query.Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        TimeEntries = await query
            .OrderByDescending(t => t.Date)
            .Select(t => new ReadTimeEntryDto(
                t.Id,
                t.Project.Name,
                t.Hours,
                t.Description,
                t.Date,
                t.WorkType.Name,
                t.Employee.FullName,
                t.EmployeeId
            ))
            .ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPostDeleteEntry(string id)
    {
        try
        {
            var timeEntry = await db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);
            if (timeEntry == null)
            {
                this.SendNotification(NotificationType.Danger, "Time entry not found");
                return RedirectToPage();
            }

            db.TimeEntries.Remove(timeEntry);
            await db.SaveChangesAsync();

            this.SendNotification(NotificationType.Success, "The time entry was removed successfully");
            
            return RedirectToPage();
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
            return RedirectToPage();
        }
    }
}

