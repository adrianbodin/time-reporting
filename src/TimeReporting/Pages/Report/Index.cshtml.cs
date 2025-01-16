using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Extensions;

namespace TimeReporting.Pages.Report;

[Authorize]
public class Index : PageModel
{
    [BindProperty(SupportsGet = true), DataType(DataType.Date)]
    public DateTime SelectedDate { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Report";
        SelectedDate = DateTime.Now;
    }

    public IActionResult OnPostDay()
    {
        Response.TriggerToast("This is a message", Toast.Primary);
        return Partial("_ReportsCurrentDay", this);
    }

}