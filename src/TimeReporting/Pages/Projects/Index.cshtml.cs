using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

[Authorize]
public class IndexModel(IAppDbContext context) : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    public IList<Project> Projects { get;set; } = null!;

    public async Task<IActionResult> OnGetAsync()
    {
        //todo fix better
        IQueryable<Project> query = context.Projects.Include(p => p.Customer).Include(p => p.TimeEntries);

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            query = query.Where(p => p.Name.ToLower().Contains(SearchTerm.ToLower()));
        }

        Projects = await query.ToListAsync();

        this.SetTitle("Projects");

        return Page();
    }
}