using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;

namespace TimeReporting.Pages.Projects;

public record ProjectDetailsDto(string Id, string Name, string Description, string Customer, double TotalHours, decimal TotalBilledAmount,List<TimeEntryDto> TimeEntries);

public record TimeEntryDto(string Id, string Employee, double Hours, DateOnly Date, string Description, string WorkType, double HourlyRate);

public record TableData(List<string> Labels, List<int> Data);

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;

    public DetailsModel(AppDbContext context)
    {
        _context = context;
    }

    public TableData TableData { get; set; }

    public ProjectDetailsDto Project { get; set; }

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        TableData = new TableData(
            new List<string>
            {
                "Red", "Blue"
            },
            new List<int>
            {
                2, 5
            });

        var project = await _context.Projects
            .Where(p => p.Id == id)
            .Select(p => new ProjectDetailsDto(
                p.Id,
                p.Name,
                p.Description,
                p.Customer.Name,
                p.TimeEntries.Sum(t => t.Hours),
                p.TimeEntries.Sum(t => (decimal)(t.Hours * t.HourlyRate)),
                p.TimeEntries.Select(t => new TimeEntryDto(
                    t.Id,
                    t.Employee.FullName,
                    t.Hours,
                    t.Date,
                    t.Description,
                    t.WorkType.Name,
                    t.HourlyRate)).ToList()))
            .FirstOrDefaultAsync();


        if (project is not null)
        {
            Project = project;

            return Page();
        }

        return NotFound();
    }
}