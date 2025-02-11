using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Extensions;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Customers;

public record EditCustomerDto
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string Name { get; set; }
}

[Authorize]
public class EditModel(IAppDbContext db) : PageModel
{
    [BindProperty]
    public EditCustomerDto Customer { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        this.SetTitle("Edit Customer");

        var customer = await db.Customers
            .Where(c => c.Id == id)
            .Select(c => new EditCustomerDto
            {
                Id = c.Id,
                Name = c.Name
            })
            .FirstOrDefaultAsync();

        if (customer is null)
        {
            this.SendNotification(NotificationType.Danger, "Customer not found.");
            return RedirectToPage("./Index");
        }

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
            this.SendNotification(NotificationType.Danger, "Customer not found.");
            return NotFound();
        }

        customer.Name = Customer.Name;
        await db.SaveChangesAsync();

        this.SendNotification(NotificationType.Success, "The customer was updated successfully");

        return RedirectToPage("./Index");
    }
}
