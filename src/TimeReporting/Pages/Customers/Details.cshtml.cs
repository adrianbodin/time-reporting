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
public class DetailsModel(IAppDbContext context) : PageModel
{
    public Customer Customer { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        this.SetTitle("Customer Details");

        if (id is null)
        {
            return NotFound();
        }

        try
        {
            var customer = await context.Customers.FirstOrDefaultAsync(m => m.Id == id);

            if (customer is null)
            {
                return NotFound();
            }

            Customer = customer;
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
            return NotFound();
        }

        return Page();
    }
}