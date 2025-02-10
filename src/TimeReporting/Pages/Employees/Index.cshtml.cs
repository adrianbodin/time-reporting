using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

public record EmployeeDto(string Id, string FullName, string JobTitle, DateTime HireDate);

[Authorize(Roles = "Admin")]
public class IndexModel : PageModel
{
    private readonly AppDbContext _db;

    public IndexModel(AppDbContext db)
    {
        _db = db;
    }

    public IList<EmployeeDto>? Employees { get; set; }

    public async Task<IActionResult> OnGet()
    {
        Employees = await _db.Users
            .AsNoTracking()
            .Select(e => new EmployeeDto(e.Id, e.FullName, e.JobTitle, DateTime.Parse(e.HireDate.ToString())))
            .ToListAsync();


        this.SetTitle("Employees");

        return Page();
    }
}