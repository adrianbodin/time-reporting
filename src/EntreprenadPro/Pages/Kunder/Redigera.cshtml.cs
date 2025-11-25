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
public class RedigeraModel(IAppDbContext db) : PageModel
{
    [BindProperty] public Customer Customer { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        var customer = await db.Customers
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();

        if (customer is null)
        {
            this.SendNotification(NotificationType.Danger, "Customer not found.");
            return RedirectToPage("./Index");
        }

        this.SetTitle($"Redigera kunden: {customer.Name}");
        Customer = customer;
        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        var customer = await db.Customers.FindAsync(Customer.Id);

        if (customer is null)
        {
            this.SendNotification(NotificationType.Danger, "Kunden kunde inte hittas.");
            return NotFound();
        }

        customer.Name = Customer.Name;
        await db.SaveChangesAsync();

        this.SendNotification(NotificationType.Success, "Kunden har uppdaterats.");

        return RedirectToPage("./Index");
    }
}