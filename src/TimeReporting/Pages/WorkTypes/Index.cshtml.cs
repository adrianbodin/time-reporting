using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.WorkTypes;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<WorkType> WorkTypes { get; set; }

    public async Task OnGetAsync()
    {
        WorkTypes = await _context.WorkTypes
            .AsNoTracking()
            .ToListAsync();
    }
}