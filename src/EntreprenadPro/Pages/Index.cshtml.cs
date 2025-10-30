using System.Security.Claims;
using EntreprenadPro.Data;
using EntreprenadPro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EntreprenadPro.Pages;

public class IndexModel(AppDbContext dbContext) : PageModel
{
    public async Task OnGet()
    {
        if (!await dbContext.UserRoles.AnyAsync())
        {
            Response.Redirect("/Account/Register");
        }
        else if (User.Identity is { IsAuthenticated: true })
        {
            Response.Redirect("/tid");
        }
        else
        {
            Response.Redirect("/Account/Login");
        }
    }
}