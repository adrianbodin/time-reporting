using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntreprenadPro.Pages.Projects.Details;

public class Analytics : PageModel
{
    public void OnGet()
    {
        ViewData["ActiveLink"] = "Analytics";
    }
}