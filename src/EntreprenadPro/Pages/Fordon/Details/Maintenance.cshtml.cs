using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static EntreprenadPro.Models.NotificationType;

namespace EntreprenadPro.Pages.Fordon.Details;

[Authorize]
public class MaintenanceModel(IAppDbContext db) : PageModel
{
    public Vehicle Vehicle { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(string identifier)
    {
        var vehicle = await db.Vehicles
            .AsNoTracking()
            .FirstOrDefaultAsync(v =>
                v.RegistrationNumber == identifier ||
                v.SerialNumber == identifier);

        if (vehicle is null)
        {
            this.SendNotification(Danger, "Fordonet hittades inte.");
            return RedirectToPage("/Fordon/Index");
        }

        Vehicle = vehicle;
        ViewData["Vehicle"] = vehicle;
        this.SetTitle($"{vehicle.Make} {vehicle.Model} - Underhåll");
        return Page();
    }
}