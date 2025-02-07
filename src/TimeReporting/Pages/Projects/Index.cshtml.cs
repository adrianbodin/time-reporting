using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

[Authorize]
public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; }

    public IList<Project> Projects { get;set; } = default!;

    public async Task<IActionResult> OnGetAsync()
    {
        IQueryable<Project> query = _context.Projects.Include(p => p.Customer);

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            query = query.Where(p => p.Name.ToLower().Contains(SearchTerm.ToLower()));
        }

        Projects = await query.ToListAsync();

        this.SetTitle("Projects");

        return Page();
    }
}