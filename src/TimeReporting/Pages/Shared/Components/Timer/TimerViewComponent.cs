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
    private readonly AppDbContext _db;

    public TimerViewComponent(AppDbContext db)
    {
        _db = db;
    }

    public int Num { get; set; }

    public TimerStatus Status { get; set; }

    public TimeSpan TimerTime { get; set; }

    public async Task<IViewComponentResult> InvokeAsync(TimeSpan? duration)
    {
        TimerTime = TimeSpan.Zero;

        if (duration.HasValue)
        {
            TimerTime = duration.Value;
        }

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

            TimerTime = DateTime.UtcNow - timer.StartTime;

            return View(this);
        }

        Status = TimerStatus.Stopped;
        return View(this);
    }
}

public record TimerTime(int Hour, int Minute);