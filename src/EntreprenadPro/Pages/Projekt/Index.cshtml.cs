using EntreprenadPro.Data;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntreprenadPro.Helpers;

namespace EntreprenadPro.Pages.Projects;

[Authorize]
public class IndexModel(IAppDbContext context) : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    public IList<Project> Projects { get;set; } = null!;

    public async Task<IActionResult> OnGetAsync()
    {
        IQueryable<Project> query = context.Projects.Include(p => p.Customer).Include(p => p.TimeEntries);

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            query = query.Where(p => p.Name.ToLower().Contains(SearchTerm.ToLower() ) || p.Customer.Name.ToLower().Contains(SearchTerm.ToLower()));
        }

        Projects = await query.ToListAsync();

        this.SetTitle("Projekt");

        return Page();
    }
}