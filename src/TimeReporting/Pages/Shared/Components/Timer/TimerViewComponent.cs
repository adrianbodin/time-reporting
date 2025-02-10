using System.Runtime.InteropServices.JavaScript;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Data;

namespace TimeReporting.Pages.Shared.Components.Timer;

public enum TimerStatus
{
    NotStarted,
    Running,
    Stopped
}

public class TimerViewComponent : ViewComponent
{
    private readonly IAppDbContext _db;

    public TimerViewComponent(IAppDbContext db)
    {
        _db = db;
    }

    public int Num { get; set; }

    public TimerStatus Status { get; set; }

    public TimeSpan Duration { get; set; }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        Duration = TimeSpan.Zero;

        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
        var timer = await _db.EntryTimers.FirstOrDefaultAsync(et => et.EmployeeId == userId);

        if (timer is null)
        {
            Status = TimerStatus.NotStarted;
            return View(this);
        }
        if (timer.EndTime is null)
        {
            Status = TimerStatus.Running;

            Duration = DateTime.UtcNow - timer.StartTime;

            return View(this);
        }

        Status = TimerStatus.Stopped;
        Duration = timer.EndTime.Value - timer.StartTime;
        return View(this);
    }
}

public record TimerTime(int Hour, int Minute);