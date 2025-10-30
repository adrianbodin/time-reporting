using EntreprenadPro.Data;
using EntreprenadPro.Extensions;
using EntreprenadPro.Helpers;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages.Anstallda;

[Authorize(Roles = "Admin")]
public class IndexModel(IAppDbContext db) : PageModel
{
    public IEnumerable<EmployeeTableDto> Employees { get; set; } = null!;

    public async Task<IActionResult> OnGet()
    {
        this.SetTitle("Alla anställda");

        try
        {
            var employees = await db.Users
                .AsNoTracking()
                .Select(e => new EmployeeTableDto(e.Id, e.FullName, e.JobTitle, DateTime.Parse(e.HireDate.ToString())))
                .ToListAsync();

            Employees = employees;
        }
        catch (Exception e)
        {
            this.SendNotification(NotificationType.Danger, "Det uppstod ett fel, försök igen.");
            return Page();
        }

        return Page();
    }
}