using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Schema;
using TimeReporting.Data;
using TimeReporting.Models;
using TimeReporting.Pages.Shared;
using static TimeReporting.Pages.Shared.GlobalFragments;

namespace TimeReporting.Pages.Reports;


public record ReadTimeEntryDto(string Id,string Customer, double Hours, string Description, DateOnly Date);

[Authorize]
public class Index : BasePageModel
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

    public async Task OnGet()
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
                t.Customer.Name,
                t.Hours,
                t.Description,
                t.Date
            ))
            .ToListAsync();
    }

    public async Task<IActionResult> OnPostDeleteEntry(string id)
    {
        try
        {
            var timeEntry = await _db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);

            _db.TimeEntries.Remove(timeEntry);
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {
            TempData["Notification-Message"] = "An error occurred while removing the entry.";
            TempData["Notification-Type"] = NotificationType.Danger;

            return Page();
        }

        TempData["Notification-Message"] = "The entry was removed successfully.";
        TempData["Notification-Type"] = NotificationType.Success;

        TimeEntries = await _db.TimeEntries
            .Where(t => t.Date == DateOnly.FromDateTime(SelectedDate))
            .Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier).Value)
            .Select(t => new ReadTimeEntryDto(
                t.Id,
                t.Customer.Name,
                t.Hours,
                t.Description,
                t.Date
            ))
            .ToListAsync();

        return Page();
    }

    public TimeEntry EditEntry { get; set; }

    public async Task<PartialViewResult> OnPostSubmitEditEntry([FromQuery]string id)
    {
        EditEntry = await _db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);

        return Partial("_EditEntryRow", this);
    }

    public ContentResult OnPostToast([FromForm] string type)
    {
        var parsedType = Enum.Parse<ToastType>(type, true);

        return Content(
            Toast("Look at the color", parsedType) +
            Hello("My message") +
            Num(parsedType.ToString().Length),
            "text/html"
            );
    }
}

