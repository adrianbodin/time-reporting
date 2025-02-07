using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Data;
using TimeReporting.Helpers;
using TimeReporting.Models;

namespace TimeReporting.Pages.Employees;

public class Edit : PageModel
{
    private readonly AppDbContext _db;

    public Edit(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public Employee Employee { get; set; } = null!;

    public void OnGet(string id)
    {
        this.SetTitle("Edit Employee");

        Employee = _db.Users.Find(id);
        if (Employee is null)
        {
            throw new Exception("Employee not found.");
        }
    }
}