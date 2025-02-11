using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Customers;

[Authorize]
public class IndexModel(IAppDbContext context) : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    public IEnumerable<Customer> Customers { get;set; } = null!;

    public async Task<IActionResult> OnGetAsync()
    {
        this.SetTitle("Customers");

        IQueryable<Customer> query = context.Customers;

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            query = query.Where(c => c.Name.ToLower().Contains(SearchTerm.ToLower()));
        }

        try
        {
            Customers = await query.ToListAsync();
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
        }

        return Page();
    }
}