using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static EntreprenadPro.Models.NotificationType;

namespace EntreprenadPro.Pages.Tid;

[Authorize]
public class Index(IAppDbContext db) : PageModel
{
    [BindProperty(SupportsGet = true)]
    [DataType(DataType.Date)]
    public DateTime SelectedDate { get; set; }

    [BindProperty(SupportsGet = true)] public string SelectedProjectId { get; set; }

    public List<ReadTimeEntryDto> TimeEntries { get; set; } = [];

    public SelectList Projects { get; set; }

    public async Task<IActionResult> OnGet()
    {
        this.SetTitle("Reports");

        // Build project SelectList from Projects table to avoid null navigation values from TimeEntries
        var projects = await db.Projects
            .OrderBy(p => p.Name)
            .ToListAsync();

        // Provide explicit value/text and selected value to match asp-for binding
        Projects = new SelectList(projects, nameof(Project.Id), nameof(Project.Name), SelectedProjectId);

        if (SelectedDate == default) SelectedDate = DateTime.Now;

        var query = db.TimeEntries.Where(t => t.Date == DateOnly.FromDateTime(SelectedDate));

        if (!string.IsNullOrEmpty(SelectedProjectId))
            // Filter using ProjectId to avoid null navigation access
            query = query.Where(t => t.ProjectId == SelectedProjectId);

        if (!User.IsInRole("Admin"))
            query = query.Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier)!.Value);

        TimeEntries = await query
            .OrderByDescending(t => t.Date)
            .Select(t => new ReadTimeEntryDto(
                t.Id,
                t.Project!.Name,
                t.Hours,
                t.Description,
                t.Date,
                t.WorkType!.Name,
                t.Employee.FullName,
                t.EmployeeId
            ))
            .ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPostDeleteEntry(string id)
    {
        var timeEntry = await db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);
        if (timeEntry is null)
        {
            this.SendNotification(Danger, "Time entry not found");
            return RedirectToPage();
        }

        db.TimeEntries.Remove(timeEntry);
        await db.SaveChangesAsync();

        this.SendNotification(Success, "The time entry was removed successfully");
        return RedirectToPage();
    }
}