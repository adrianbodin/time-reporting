using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Extensions;

namespace TimeReporting.Pages.Report;

[Authorize]
public class Index : PageModel
{
    [BindProperty, DataType(DataType.Date)]
    public DateTime SelectedDate { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Report";
        SelectedDate = DateTime.Now;
        Admin = User.IsInRole("Admin");
    }

    public bool Admin { get; set; }

    public IActionResult OnPostDay()
    {
        Response.TriggerToast("This is a message", Toast.Primary);
        return Partial("_ReportsCurrentDay", this);
    }

}