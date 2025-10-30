using EntreprenadPro.Data;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntreprenadPro.Helpers;

namespace EntreprenadPro.Pages.WorkTypes;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<WorkType> WorkTypes { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        WorkTypes = await _context.WorkTypes
            .AsNoTracking()
            .ToListAsync();

        this.SetTitle("Work Types");

        return Page();
    }
}