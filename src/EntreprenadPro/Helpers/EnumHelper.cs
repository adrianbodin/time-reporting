using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EntreprenadPro.Helpers;

public static class EnumHelper
{
    public static string GetDisplayName<TEnum>(TEnum value) where TEnum : Enum
    {
        var member = typeof(TEnum).GetMember(value.ToString()).FirstOrDefault();
        var attr = member?.GetCustomAttributes(typeof(DisplayAttribute), false)
            .OfType<DisplayAttribute>()
            .FirstOrDefault();
        return attr?.Name ?? value.ToString();
    }

    public static IEnumerable<SelectListItem> GetSelectList<TEnum>() where TEnum : Enum
    {
        return Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(e => new SelectListItem
            {
                Text = GetDisplayName(e),
                Value = e.ToString()
            });
    }
}