using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Report;

public record AddTimeEntryDto()
{
    [Required]
    public string CustomerId { get; set; }

    [Required]
    [Range(0.5, 24, ErrorMessage = "Hours must be between 0.5 and 24.")]
    public double Hours { get; set; }

    [Required]
    public string Description { get; set; }

    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateTime Date { get; set; }
}

[Authorize]
public class Create : PageModel
{
    private readonly AppDbContext _db;

    public Create(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public AddTimeEntryDto NewEntry { get; set; }

    public List<Customer> Customers { get; set; }

    public async Task OnGet()
    {
        NewEntry = new AddTimeEntryDto();
        NewEntry.Date = DateTime.Now;
        Customers = await _db.Customers.ToListAsync();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var timeEntry = new TimeEntry
        {
            Id = Guid.NewGuid().ToString(),
            CustomerId = NewEntry.CustomerId,
            EmployeeId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
            Hours = NewEntry.Hours,
            Description = NewEntry.Description,
            Date = DateOnly.FromDateTime(NewEntry.Date)
        };

        try
        {
            _db.TimeEntries.Add(timeEntry);
            await _db.SaveChangesAsync();

            TempData["Toast-Success"] = "The time entry was added successfully";
        }
        catch (Exception e)
        {
            TempData["Toast-Danger"] = "There was an error adding the new time entry";
        }

        return RedirectToPage("/Report/Index", new { SelectedDate = NewEntry.Date.ToString("yyyy-MM-dd") });

    }
}