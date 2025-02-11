using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Models;

namespace TimeReporting.Pages.Customers;

[Authorize]
public class CreateModel(IAppDbContext context) : PageModel
{
    [BindProperty]
    public Customer Customer { get; set; } = null!;

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
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            context.Customers.Add(Customer);
            await context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "There was an error, please try again.");
        }

        this.SendNotification(NotificationType.Success, $"The customer {Customer.Name} was added successfully");
        return RedirectToPage("./Index");
    }
}