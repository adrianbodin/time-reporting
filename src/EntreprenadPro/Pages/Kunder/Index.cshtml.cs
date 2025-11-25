using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Kunder;

[Authorize]
public class IndexModel(IAppDbContext context) : PageModel
{
    [BindProperty(SupportsGet = true)] public string? SearchTerm { get; set; }

    public IEnumerable<Customer> Customers { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync()
    {
        this.SetTitle("Kunder");

        IQueryable<Customer> query = context.Customers;

        if (!string.IsNullOrEmpty(SearchTerm))
            query = query.Where(c => c.Name.ToLower().Contains(SearchTerm.ToLower()));

        try
        {
            Customers = await query.ToListAsync();
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "Det uppstod ett fel, försök igen.");
        }

        return Page();
    }

    public IActionResult OnGetHtmx()
    {
        return Content("<h1>Welcome HTMX</h1>", "text/html");
    }
}