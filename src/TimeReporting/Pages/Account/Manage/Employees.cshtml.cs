using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeReporting.Pages.Account.Manage;

public class Employees : PageModel
{
    public IActionResult OnGet()
    {
        return Page();
    }
}