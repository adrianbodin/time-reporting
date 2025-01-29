using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Customers;

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

    public IList<Customer> Customers { get;set; } = default!;

    public async Task<IActionResult> OnGetAsync()
    {
        IQueryable<Customer> query = _context.Customers;

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            query = query.Where(c => c.Name.ToLower().Contains(SearchTerm.ToLower()));
        }

        Customers = await query.ToListAsync();

        return Page();
    }
}