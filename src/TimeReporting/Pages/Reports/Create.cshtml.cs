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
using static TimeReporting.Models.NotificationType;

namespace TimeReporting.Pages.Reports;

public record AddTimeEntryDto()
{
    [Required]
    public string ProjectId { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required]
    public string Description { get; set; }

    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required]
    public string WorkTypeId { get; set; }
}

[Authorize]
public class Create : PageModel
{
    private readonly IAppDbContext _db;

    public Create(IAppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public AddTimeEntryDto NewEntry { get; set; }

    [BindProperty(SupportsGet = true)]
    public bool FromTimer { get; set; }

    public IList<Project> Projects { get; set; }

    public IList<WorkType> WorkTypes { get; set; }

    public async Task OnGet([FromQuery] int? hours, [FromQuery] int? minutes)
    {
        this.SetTitle("New Time Entry");
        NewEntry = new AddTimeEntryDto
        {
            Date = DateTime.Now
        };

        if (hours.HasValue && minutes.HasValue)
        {
            double totalHours = hours.Value + Math.Ceiling((double)minutes.Value / 30) * 0.5;
            NewEntry.Hours = totalHours;
            FromTimer = true;  // Set this when coming from timer
        }

        Projects = await _db.Projects.AsNoTracking().ToListAsync();
        WorkTypes = await _db.WorkTypes.AsNoTracking().ToListAsync();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var workType = await _db.WorkTypes.FindAsync(NewEntry.WorkTypeId);
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
            HourlyRate = workType.HourlyRate
        };

        _db.TimeEntries.Add(timeEntry);

        if (FromTimer)
        {
            var timer = await _db.EntryTimers.FirstOrDefaultAsync(t =>
                t.EmployeeId == userId &&
                t.EndTime != null);

            if (timer != null)
            {
                _db.EntryTimers.Remove(timer);
            }
        }

        await _db.SaveChangesAsync();

        this.SendNotification(Success, "The time entry was added successfully");
        return RedirectToPage("./Index");
    }

}