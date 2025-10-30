using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntreprenadPro.Helpers;

public static class Unpoly
{
    public static void SetTitle(this PageModel model, string title)
    {
        var jsonTitle = System.Text.Json.JsonSerializer.Serialize(title);
        model.Response.Headers.Append("X-Up-Title", jsonTitle);
        model.ViewData["Title"] = title;
    }
}