using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeReporting.Models;

namespace TimeReporting.Extensions;

public static class PageModelExtensions
{
    //todo better type safety
    public static void SendNotification(this PageModel model, string type, string message)
    {
        model.TempData["Notification-Type"] = type;
        model.TempData["Notification-Message"] = message;
    }
}