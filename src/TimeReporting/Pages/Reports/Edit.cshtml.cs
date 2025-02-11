using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Reports;

public record EditTimeEntryDto
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string ProjectId { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required]
    public string Description { get; set; }

    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateOnly Date { get; set; }

    [Required]
    public string WorkTypeId { get; set; }
}

[Authorize]
public class Edit(IAppDbContext db) : PageModel
{
    [BindProperty]
    public EditTimeEntryDto Entry { get; set; }

    public IList<Project> Projects { get; set; } = null!;

    public IList<WorkType> WorkTypes { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        this.SetTitle("Edit Time Entry");

        var entry = await db.TimeEntries
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
            this.SendNotification(NotificationType.Danger, "Time entry not found.");
            return RedirectToPage("./Index");
        }


        Projects = await db.Projects.AsNoTracking().ToListAsync();
        WorkTypes = await db.WorkTypes.AsNoTracking().ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            // Reload the collections before returning the page
            Projects = await db.Projects.AsNoTracking().ToListAsync();
            WorkTypes = await db.WorkTypes.AsNoTracking().ToListAsync();
            
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        var timeEntry = await db.TimeEntries.FindAsync(Entry.Id);

        if (timeEntry is null)
        {
            this.SendNotification(NotificationType.Danger, "Time entry not found.");
            return NotFound();
        }

        timeEntry.Hours = Entry.Hours;
        timeEntry.Description = Entry.Description;
        timeEntry.Date = Entry.Date;
        timeEntry.WorkTypeId = Entry.WorkTypeId;
        await db.SaveChangesAsync();

        this.SendNotification(NotificationType.Success, "The time entry was updated successfully");

        return RedirectToPage("/Reports/Index", new { SelectedDate = Entry.Date.ToString("yyyy-MM-dd") });
    }
}