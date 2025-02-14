using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;

namespace TimeReporting.Pages.Shared.Components.Timer;

public class TimerViewComponent(IAppDbContext db) : ViewComponent
{
    public TimerStatus Status { get; set; }

    public TimeSpan Duration { get; set; }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
        var timer = await db.EntryTimers.FirstOrDefaultAsync(et => et.EmployeeId == userId);

        (Status, Duration) = timer switch
        {
            _ when timer is null => (TimerStatus.NotStarted, TimeSpan.Zero),
            _ when timer.EndTime is null => (TimerStatus.Running, DateTime.UtcNow - timer.StartTime),
            _ => (TimerStatus.Stopped, timer.EndTime.Value - timer.StartTime)
        };

        return View(this);
    }
}

public enum TimerStatus
{
    NotStarted,
    Running,
    Stopped
}