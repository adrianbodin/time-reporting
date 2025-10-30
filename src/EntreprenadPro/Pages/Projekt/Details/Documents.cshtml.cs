using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntreprenadPro.Pages.Projects.Details;

public class Documents : PageModel
{
    public void OnGet()
    {
        ViewData["ActiveLink"] = "Documents";
    }
}