using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Reports;


public record ReadTimeEntryDto(string Id,string Project, double Hours, string Description, DateOnly Date, string WorkType);

[Authorize]
public class Index : PageModel
{
    private readonly AppDbContext _db;

    public Index(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateTime SelectedDate { get; set; }

    public List<ReadTimeEntryDto> TimeEntries { get; set; }

    public List<Customer> Customers { get; set; }

    public async Task<IActionResult> OnGet()
    {
        ViewData["Title"] = "Report";
        Customers = await _db.Customers.ToListAsync();

        if (SelectedDate == default)
        {
            SelectedDate = DateTime.Now;
        }

        TimeEntries = await _db.TimeEntries
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

        this.SetTitle("Reports");

        return Page();
    }

    public async Task<IActionResult> OnPostDeleteEntry(string id)
    {
        try
        {
            var timeEntry = await _db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);

            _db.TimeEntries.Remove(timeEntry);
            await _db.SaveChangesAsync();

            TempData["Notification-Message"] = "The entry was removed successfully.";
            TempData["Notification-Type"] = NotificationType.Success;

            TimeEntries = await _db.TimeEntries
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
            TempData["Notification-Message"] = "An error occurred while removing the entry.";
            TempData["Notification-Type"] = NotificationType.Danger;

            return Page();
        }

    }
}

