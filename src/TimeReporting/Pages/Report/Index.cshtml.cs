using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Models;

namespace TimeReporting.Pages.Report;


public record ReadTimeEntryDto(string Id,string Customer, double Hours, string Description);

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

    public async Task OnGet()
    {
        ViewData["Title"] = "Report";
        SelectedDate = DateTime.Now;
        Customers = await _db.Customers.ToListAsync();

        TimeEntries = await _db.TimeEntries
            .Where(t => t.Date == DateOnly.FromDateTime(DateTime.Now))
            .Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier).Value)
            .Select(t => new ReadTimeEntryDto(
                t.Id,
                t.Customer.Name,
                t.Hours,
                t.Description
                ))
            .ToListAsync();
    }

    public async Task<PartialViewResult> OnPostEntries()
    {
        TimeEntries = await _db.TimeEntries
            .Where(t => t.Date == DateOnly.FromDateTime(SelectedDate))
            .Where(t => t.EmployeeId == User.FindFirst(ClaimTypes.NameIdentifier).Value)
            .Select(t => new ReadTimeEntryDto(
                t.Id,
                t.Customer.Name,
                t.Hours,
                t.Description
            ))
            .ToListAsync();

        return Partial("_ReportsCurrentDay", this);
    }

    public async Task<IActionResult> OnDeleteEntries(string id)
    {
        var timeEntry = await _db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);

        if (timeEntry != null)
        {
            _db.TimeEntries.Remove(timeEntry);
            await _db.SaveChangesAsync();
        }

        Response.TriggerToast("The time entry was deleted", Toast.Success);

        return new EmptyResult();
    }

    public TimeEntry EditEntry { get; set; }

    public async Task<PartialViewResult> OnPostSubmitEditEntry([FromQuery]string id)
    {
        EditEntry = await _db.TimeEntries.FirstOrDefaultAsync(t => t.Id == id);

        return Partial("_EditEntryRow", this);
    }
}