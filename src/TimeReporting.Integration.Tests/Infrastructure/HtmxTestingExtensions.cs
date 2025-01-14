namespace TimeReporting.Integration.Tests.Infrastructure;

public static class HtmxTestingExtensions
{
    private const string Continue = "playwright:continue";

    public static Task WaitForHtmx(this IPage page)
    {
        return page.WaitForConsoleMessageAsync(new() {
            Predicate = message => message.Text == Continue
        });
    }

    public static Task RegisterHtmxLifecycleListener(this IPage page)
    {
        return page.AddScriptTagAsync(new()
        {
            // language=javascript
            Content = $$"""
                        document.body.addEventListener('htmx:afterSettle', function(evt) {
                            console.log('{{Continue}}');
                        });
                        """
        });
    }
}