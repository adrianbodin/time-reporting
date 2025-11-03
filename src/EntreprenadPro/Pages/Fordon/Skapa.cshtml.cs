using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntreprenadPro.Pages.Fordon;

public class SkapaModel(IAppDbContext context) : PageModel
{
    [BindProperty] public AddVehicleDto Vehicle { get; set; } = new();

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            return Page();
        }

        var vehicle = new Vehicle
        {
            Id = Guid.NewGuid().ToString(),
            Type = Vehicle.Type,
            RegistrationNumber = Vehicle.RegistrationNumber,
            Make = Vehicle.Make,
            Model = Vehicle.Model,
            Year = Vehicle.Year,
            PurchasePrice = Vehicle.PurchasePrice,
            PurchaseDate = Vehicle.PurchaseDate.HasValue
                ? DateTime.SpecifyKind(Vehicle.PurchaseDate.Value, DateTimeKind.Utc)
                : null,
            Note = Vehicle.Note
        };

        try
        {
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();
            this.SendNotification(NotificationType.Success, "Fordonet skapades.");
            return RedirectToPage("/Fordon/Index");
        }
        catch
        {
            this.SendNotification(NotificationType.Danger, "Det uppstod ett fel, försök igen.");
            return Page();
        }
    }
}