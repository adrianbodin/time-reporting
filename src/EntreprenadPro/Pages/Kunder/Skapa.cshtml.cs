using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static EntreprenadPro.Models.NotificationType;

namespace EntreprenadPro.Pages.Kunder;

[Authorize]
public class SkapaModel(IAppDbContext context) : PageModel
{
    [BindProperty] public Customer Customer { get; set; } = null!;

    public IActionResult OnGet()
    {
        Customer = new Customer
        {
            Id = Guid.NewGuid().ToString()
        };

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        try
        {
            context.Customers.Add(Customer);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            this.SendNotification(Danger, "Det uppstod ett fel, försök igen.");
        }

        this.SendNotification(Success, $"Kunden {Customer.Name} har lagts till.");
        return RedirectToPage("/Kunder/Index");
    }
}