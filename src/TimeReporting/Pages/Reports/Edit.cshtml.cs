using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Models;
using static TimeReporting.Models.NotificationType;

namespace TimeReporting.Pages.Reports;

[Authorize]
public class Edit(IAppDbContext db) : PageModel
{
    [BindProperty]
    public EditTimeEntryDto Entry { get; set; }

    public IList<Project> Projects { get; set; } = null!;

    public IList<WorkType> WorkTypes { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        var entry = await db.TimeEntries
                .AsNoTracking()
            .Where(te => te.Id == id)
            .Select(t => new EditTimeEntryDto
                {
                    Id = t.Id,
                    ProjectId = t.ProjectId,
                    Hours = t.Hours,
                    WorkTypeId = t.WorkTypeId,
                    Description = t.Description,
                    Date = t.Date,
                })
            .FirstOrDefaultAsync();

        if (entry is null)
        {
            this.SendNotification(Danger, "Time entry not found.");
            return RedirectToPage("./Index");
        }

        Entry = entry;
        Projects = await db.Projects.AsNoTracking().ToListAsync();
        WorkTypes = await db.WorkTypes.AsNoTracking().ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            Projects = await db.Projects.AsNoTracking().ToListAsync();
            WorkTypes = await db.WorkTypes.AsNoTracking().ToListAsync();
            return Page();
        }

        var timeEntry = await db.TimeEntries
            .FirstOrDefaultAsync(t => t.Id == Entry.Id);

        if (timeEntry is null)
        {
            this.SendNotification(Danger, "Time entry not found.");
            return RedirectToPage("./Index");
        }

        timeEntry.ProjectId = Entry.ProjectId;
        timeEntry.Hours = Entry.Hours;
        timeEntry.Description = Entry.Description;
        timeEntry.Date = Entry.Date;
        timeEntry.WorkTypeId = Entry.WorkTypeId;

        await db.SaveChangesAsync();

        this.SendNotification(Success, "The time entry was updated successfully");
        return RedirectToPage("./Index");
    }
}