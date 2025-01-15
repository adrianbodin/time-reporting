using TimeReporting.Integration.Tests.Infrastructure;

namespace TimeReporting.Integration.Tests;

public class NavigationTests : IntegrationTestBase
{
    public NavigationTests(IntegrationTestWebAppFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task WhenUserIsNotAuthenticatedThenUserIsRedirectedToLoginPage()
    {
        await Page.GotoAsync($"{RootUrl}");

        Assert.Contains(Page.Url, "Login");
    }
}