using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
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
public class Edit : PageModel
{
    private readonly AppDbContext _db;

    public Edit(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public EditTimeEntryDto? Entry { get; set; }

    public IList<Project> Projects { get; set; }

    public IList<WorkType> WorkTypes { get; set; }

    public async Task<IActionResult> OnGet(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return NotFound();
        }

        ViewData["Title"] = "Edit Time Entry";

        Entry = await _db.TimeEntries
            .Where(te => te.Id == id)
            .Select(t => new EditTimeEntryDto
                {
                    Id = t.Id,
                    ProjectId = t.ProjectId,
                    Hours = t.Hours,
                    Description = t.Description,
                    Date = t.Date,
                })
            .FirstOrDefaultAsync();


        Projects = await _db.Projects.AsNoTracking().ToListAsync();
        WorkTypes = await _db.WorkTypes.AsNoTracking().ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        return Page();
    }
}