using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static EntreprenadPro.Models.NotificationType;

namespace EntreprenadPro.Pages.Tid;

public class AddTimeEntryDto
{
    public int? ProjectId { get; set; }

    [Required] public TimeEntryType TimeEntryType { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required] public string Description { get; set; }

    [BindProperty(SupportsGet = true)]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required] public string? WorkTypeId { get; set; }
}

[Authorize]
public class Skapa(IAppDbContext db) : PageModel
{
    [BindProperty] public AddTimeEntryDto NewEntry { get; set; }

    public IList<Project> Projects { get; set; }

    public IList<WorkType> WorkTypes { get; set; }

    public async Task OnGet([FromQuery] int? hours, [FromQuery] int? minutes)
    {
        this.SetTitle("New Time Entry");
        NewEntry = new AddTimeEntryDto
        {
            Date = DateTime.Now
        };

        Projects = await db.Projects.AsNoTracking().ToListAsync();
        WorkTypes = await db.WorkTypes.AsNoTracking().ToListAsync();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid) return Page();

        var workType = await db.WorkTypes.FindAsync(NewEntry.WorkTypeId);
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        var timeEntry = new TimeEntry
        {
            Id = Guid.NewGuid().ToString(),
            ProjectId = NewEntry.ProjectId,
            EmployeeId = userId,
            Hours = NewEntry.Hours,
            Description = NewEntry.Description,
            Date = DateOnly.FromDateTime(NewEntry.Date),
            WorkTypeId = NewEntry.WorkTypeId,
            HourlyRate = workType.HourlyRate,
            Type = NewEntry.TimeEntryType
        };

        db.TimeEntries.Add(timeEntry);

        await db.SaveChangesAsync();

        this.SendNotification(Success, "Tidrapporten har skapats.");
        return RedirectToPage("/Tid/Index");
    }
}