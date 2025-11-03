using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Fordon;

public class RaderaModel(IAppDbContext context) : PageModel
{
    [BindProperty] public Vehicle Vehicle { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(string? id)
    {
        if (id == null) return NotFound();

        try
        {
            var vehicle = await context.Vehicles.FirstOrDefaultAsync(m => m.Id == id);

            if (vehicle is null)
            {
                this.SendNotification(NotificationType.Danger, "Fordonet hittades inte.");
                return NotFound();
            }

            Vehicle = vehicle;
        }
        catch
        {
            this.SendNotification(NotificationType.Danger, "Det uppstod ett fel, försök igen.");
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string? id)
    {
        if (id == null) return NotFound();

        try
        {
            var vehicle = await context.Vehicles.FindAsync(id);

            if (vehicle is null)
            {
                this.SendNotification(NotificationType.Danger, "Fordonet hittades inte.");
                return NotFound();
            }

            context.Vehicles.Remove(vehicle);
            await context.SaveChangesAsync();

            this.SendNotification(NotificationType.Success, "Fordonet togs bort.");
        }
        catch
        {
            this.SendNotification(NotificationType.Danger, "Det uppstod ett fel, försök igen.");
            return NotFound();
        }

        return RedirectToPage("./Index");
    }
}