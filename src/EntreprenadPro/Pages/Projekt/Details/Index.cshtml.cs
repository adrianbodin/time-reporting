using EntreprenadPro.Data;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Projects.Details;

public record ProjectDetailsDto(
    string Id,
    string Name,
    string Description,
    string Customer,
    double TotalHours,
    decimal TotalBilledAmount,
    ProjectStatus Status,
    List<TimeEntryDto> TimeEntries);

public record TimeEntryDto(
    string Id,
    string EmployeeId,
    string Employee,
    double Hours,
    DateOnly Date,
    string Description,
    string WorkType,
    double HourlyRate);

public class DetailsModel(IAppDbContext context) : PageModel
{
    public object TableData { get; set; } = null!;

    public ProjectDetailsDto Project { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (id is null)
            return NotFound();

        var project = await context.Projects
            .Where(p => p.Id == id)
            .Select(p => new ProjectDetailsDto(
                p.Id,
                p.Name,
                p.Description,
                p.Customer.Name,
                p.TimeEntries.Sum(t => t.Hours),
                p.TimeEntries.Sum(t => (decimal)(t.Hours * t.HourlyRate)),
                p.Status,
                p.TimeEntries.Select(t => new TimeEntryDto(
                        t.Id,
                        t.EmployeeId,
                        t.Employee.FullName,
                        t.Hours,
                        t.Date,
                        t.Description,
                        t.WorkType.Name,
                        t.HourlyRate))
                    .ToList()))
            .FirstOrDefaultAsync();

        if (project is null)
            return NotFound();


        Project = project;

        var employeeHours = Project.TimeEntries
            .GroupBy(t => new { Id = t.EmployeeId, Name = t.Employee })
            .Select(g => new
            {
                Employee = g.Key.Name,
                Hours = g.Sum(t => t.Hours)
            })
            .OrderBy(x => x.Hours)
            .ToList();

        TableData = new
        {
            Labels = employeeHours.Select(x => x.Employee).ToList(),
            Data = employeeHours.Select(x => x.Hours).ToList()
        };

        this.SetTitle($"{Project.Name}");

        return Page();
    }
}