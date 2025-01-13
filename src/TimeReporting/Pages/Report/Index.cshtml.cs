using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Extensions;

namespace TimeReporting.Pages.Report;

public class Index : PageModel
{
    [BindProperty, DataType(DataType.Date)]
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