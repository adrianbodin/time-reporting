namespace TimeReporting.Integration.Tests.Helpers;

public static class Authentication
{

    public static async Task AuthenticateAdminAsync(this IPage page, string rootUrl)
    {
        await page.GotoAsync($"{rootUrl}");

        await page.GetByTestId("email-input").First.FillAsync("admin@example.com");
        await page.GetByTestId("password-input").First.FillAsync("Admin123!");
        await page.GetByTestId("remember-me-checkbox").First.ClickAsync();
        await page.GetByTestId("submit-button").First.ClickAsync();
    }

    public static async Task AuthenticateEmployeeAsync(this IPage page, string rootUrl)
    {
        await page.GotoAsync($"{rootUrl}");

        await page.GetByTestId("email-input").FillAsync("employee@gmail.com");
        await page.GetByTestId("password-input").FillAsync("Employee123!");
        await page.GetByTestId("submit-button").ClickAsync();
    }
}