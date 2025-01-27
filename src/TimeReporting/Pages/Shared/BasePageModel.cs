using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TimeReporting.Pages.Shared;

public static class NotificationType
{
    public const string Success = "success";
    public const string Info = "info";
    public const string Warning = "warning";
    public const string Danger = "danger";
    public const string Dark = "dark";
}

public class BasePageModel : PageModel
{
}