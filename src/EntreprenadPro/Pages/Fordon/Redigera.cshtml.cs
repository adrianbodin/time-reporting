using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static EntreprenadPro.Models.NotificationType;

namespace EntreprenadPro.Pages.Fordon;

[Authorize]
public class RedigeraModel(IAppDbContext db) : PageModel
{
    [BindProperty] public EditVehicleDto Vehicle { get; set; } = null!;

    public async Task<IActionResult> OnGet(string id)
    {
        var vehicle = await db.Vehicles
            .Where(v => v.Id == id)
            .Select(v => new EditVehicleDto
            {
                Id = v.Id,
                Type = v.Type,
                RegistrationNumber = v.RegistrationNumber,
                Make = v.Make,
                Model = v.Model,
                Year = v.Year,
                PurchasePrice = v.PurchasePrice,
                PurchaseDate = v.PurchaseDate,
                Note = v.Note
            })
            .FirstOrDefaultAsync();

        if (vehicle is null)
        {
            this.SendNotification(Danger, "Fordonet hittades inte.");
            return RedirectToPage("./Index");
        }

        Vehicle = vehicle;
        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        var vehicle = await db.Vehicles.FindAsync(Vehicle.Id);
        if (vehicle is null)
        {
            this.SendNotification(Danger, "Fordonet hittades inte.");
            return NotFound();
        }

        vehicle.Type = Vehicle.Type;
        vehicle.RegistrationNumber = Vehicle.RegistrationNumber;
        vehicle.Make = Vehicle.Make;
        vehicle.Model = Vehicle.Model;
        vehicle.Year = Vehicle.Year;
        vehicle.PurchasePrice = Vehicle.PurchasePrice;
        vehicle.PurchaseDate = Vehicle.PurchaseDate.HasValue
            ? DateTime.SpecifyKind(Vehicle.PurchaseDate.Value, DateTimeKind.Utc)
            : null;
        vehicle.Note = Vehicle.Note;

        await db.SaveChangesAsync();

        this.SendNotification(Success, "Fordonet har uppdaterats.");
        return RedirectToPage("./Index");
    }
}