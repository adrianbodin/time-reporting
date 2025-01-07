using System.Text.Json;

namespace TimeReporting.Extensions;

public static class HttpResponseExtensions
{
    public static void TriggerToast(this HttpResponse response, string message, Toast? toast = null)
    {
        var values = new
        {
            showMessage = new
            {
                message,
                type = toast?.ToString().ToLower()
            }
        };

        response.Headers["HX-Trigger"] = JsonSerializer.Serialize(values);
    }
}

public enum Toast
{
    Success,
    Primary,
    Error,
}