using Microsoft.AspNetCore.Mvc;

namespace TimeReporting.Pages.Shared.Components.Timer;

public class TimerViewComponent : ViewComponent
{
    public int Num { get; set; }

    public IViewComponentResult Invoke()
    {
        Num = new Random().Next(1, 89);
        return View(this);
    }
}