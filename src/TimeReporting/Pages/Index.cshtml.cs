using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;

namespace TimeReporting.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _dbContext;

    public IndexModel(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task OnGet()
    {
        if (!await _dbContext.Users.AnyAsync())
        {
            Response.Redirect("/Account/Register");
        }
        else if(User.Identity.IsAuthenticated)
        {
            Response.Redirect("/Reports");
        }
        else
        {
            Response.Redirect("/Account/Login");
        }
    }

    public async Task<IActionResult> OnGetNum()
    {
        return ViewComponent("Timer");
    }
}