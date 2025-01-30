using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

public record ProjectDetailsDto(string Id, string Name, string Description, string Customer, double TotalHours, List<TimeEntryDto> TimeEntries);

public record TimeEntryDto(string Id, string Employee, double Hours, DateOnly Date, string Description);

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;

    public DetailsModel(AppDbContext context)
    {
        _context = context;
    }

    public ProjectDetailsDto Project { get; set; }

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var project = await _context.Projects
            .Where(p => p.Id == id)
            .Select(p => new ProjectDetailsDto(
                p.Id,
                p.Name,
                p.Description,
                p.Customer.Name,
                p.TimeEntries.Sum(t => t.Hours),
                p.TimeEntries.Select(t => new TimeEntryDto(
                    t.Id,
                    t.Employee.FullName,
                    t.Hours,
                    t.Date,
                    t.Description)).ToList()))
            .FirstOrDefaultAsync();

        if (project is not null)
        {
            Project = project;

            return Page();
        }

        return NotFound();
    }
}