using System.ComponentModel.DataAnnotations;
using System.Globalization;
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

    [BindProperty(SupportsGet = true)] public int SelectedProjectId { get; set; } = 0;

    public List<ReadTimeEntryDto> TimeEntries { get; set; } = [];

    public SelectList Projects { get; set; }

    public async Task<IActionResult> OnGet()
    {
        if (SelectedDate.Year == 0001) SelectedDate = DateTime.Now;

        this.SetTitle(
            $"V.{ISOWeek.GetWeekOfYear(SelectedDate)} {SelectedDate.ToString("ddd d MMM yyyy", new CultureInfo("sv-SE"))}");

        var projects = await db.Projects
            .OrderBy(p => p.Name)
            .ToListAsync();

        Projects = new SelectList(projects, nameof(Project.Id), nameof(Project.Name), SelectedProjectId);

        if (SelectedDate == default) SelectedDate = DateTime.Now;

        var query = db.TimeEntries.Where(t => t.Date == DateOnly.FromDateTime(SelectedDate));

        if (SelectedProjectId != 0)
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
                t.EmployeeId,
                t.Type
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