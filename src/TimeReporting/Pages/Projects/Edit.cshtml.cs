using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

public class EditModel(IAppDbContext context) : PageModel
{
    [BindProperty]
    public Project Project { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        var project = await context.Projects.FirstOrDefaultAsync(m => m.Id == id);

        if (project == null)
        {
            return NotFound();
        }

        Project = project;
        return Page();
    }
}