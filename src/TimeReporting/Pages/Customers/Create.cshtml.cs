using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Pages.Customers;

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        Customer = new Customer
        {
            Id = Guid.NewGuid().ToString()
        };
        return Page();
    }

    [BindProperty]
    public Customer Customer { get; set; } = null!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        try
        {
            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            TempData["Notification-Type"] = NotificationType.Success;
            TempData["Notification-Message"] = $"The customer {Customer.Name} was added successfully";
        }
        catch (Exception e)
        {
            TempData["Toast-Type"] = NotificationType.Danger;
            TempData["Toast-Message"] = $"There was an error adding the customer {Customer.Name}";
        }

        return RedirectToPage("./Index");
    }
}