using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Kunder.Details;

[Authorize]
public class Index(IAppDbContext context) : PageModel
{
    public Customer Customer { get; private set; } = null!;

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            this.SendNotification(NotificationType.Warning, "Ingen kund angavs.");
            return RedirectToPage("/Kunder/Index");
        }

        var customer = await context.Customers
            .AsNoTracking()
            .Include(c => c.Projects)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (customer is null)
        {
            this.SendNotification(NotificationType.Danger, "Kunden kunde inte hittas.");
            return RedirectToPage("/Kunder/Index");
        }

        Customer = customer;
        this.SetTitle(customer.Name);

        return Page();
    }
}