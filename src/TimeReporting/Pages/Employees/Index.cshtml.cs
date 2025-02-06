using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

[Authorize(Roles = "Admin")]
public class IndexModel : PageModel
{
    private readonly AppDbContext _db;

    public IndexModel(AppDbContext db)
    {
        _db = db;
    }

    public IList<Employee>? Employees { get; set; }

    public async Task<IActionResult> OnGet()
    {
        Employees = await _db.Users.AsNoTracking().ToListAsync();

        this.SetTitle("Employees");

        return Page();
    }
}