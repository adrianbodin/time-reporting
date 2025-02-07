using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;
using TimeReporting.Models;

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
        else if (User.Identity.IsAuthenticated)
        {
            Response.Redirect("/Reports");
        }
        else
        {
            Response.Redirect("/Account/Login");
        }
    }

    public async Task<IActionResult> OnGetStartTimer()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var timer = await _dbContext.EntryTimers.FirstOrDefaultAsync(et => et.EmployeeId == userId);


        if (timer is null)
        {

            var newEntryTimer = new EntryTimer
            {
                Id = Guid.NewGuid().ToString(),
                StartTime = DateTime.UtcNow,
                EmployeeId = userId
            };

            _dbContext.EntryTimers.Add(newEntryTimer);
            await _dbContext.SaveChangesAsync();
        }

        return ViewComponent("Timer");
    }

    public async Task<IActionResult> OnGetStopTimer([FromQuery] int hours, [FromQuery] int minutes)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var timer = await _dbContext.EntryTimers.FirstOrDefaultAsync(et => et.EmployeeId == userId);

        if (timer is not null)
        {
            timer.EndTime = DateTime.UtcNow;
            var duration = timer.EndTime - timer.StartTime;
            await _dbContext.SaveChangesAsync();
            return ViewComponent("Timer", new { duration });
        }

        return ViewComponent("Timer");
    }
}