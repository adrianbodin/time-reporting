using EntreprenadPro.Data;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Fordon;

[Authorize]
public class IndexModel(IAppDbContext context) : PageModel
{
    [BindProperty(SupportsGet = true)] public string? SearchTerm { get; set; }

    public IList<Vehicle> Vehicles { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync()
    {
        var query = context.Vehicles.AsQueryable();

        if (!string.IsNullOrWhiteSpace(SearchTerm))
        {
            var term = SearchTerm.ToLower();
            query = query.Where(v =>
                (v.RegistrationNumber ?? "").ToLower().Contains(term) ||
                (v.Make ?? "").ToLower().Contains(term) ||
                (v.Model ?? "").ToLower().Contains(term));
        }

        Vehicles = await query.AsNoTracking().ToListAsync();

        this.SetTitle("Fordon");
        return Page();
    }
}