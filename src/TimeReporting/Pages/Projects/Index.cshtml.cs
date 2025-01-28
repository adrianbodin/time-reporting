using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Projects;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Project> Projects { get;set; } = default!;

    public async Task OnGetAsync()
    {
        Projects = await _context.Projects
            .Include(p => p.Customer).ToListAsync();
    }
}