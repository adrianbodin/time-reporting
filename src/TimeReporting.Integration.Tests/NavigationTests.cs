using TimeReporting.Integration.Tests.Infrastructure;

namespace TimeReporting.Integration.Tests;

public class NavigationTests : IntegrationTestBase
{
    public NavigationTests(IntegrationTestWebAppFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingToTheIntroPage()
    {
        (await Page.TitleAsync()).Should().Contain("Software");
    }

    [Fact]
    public async Task WhenUserClicksOnReportLinkThenUserIsRedirectedToReportPage()
    {
        await Page.GetByRole(AriaRole.Link, new() { Name = "Report", Exact = true }).ClickAsync();
        (await Page.TitleAsync()).Should().Contain("Report");
        Assert.Equal($"{RootUrl}report", Page.Url);
    }

    [Fact]
    public async Task WhenUserClicksRegisterLinkThenUserIsRedirectedToRegisterPage()
    {
        await Page.GetByRole(AriaRole.Link, new() { Name = "Register", Exact = true }).ClickAsync();
        Page.Url.Should().Contain("Register");
    }

    [Fact]
    public async Task WhenUserClicksLoginLinkThenUserIsRedirectedToLoginPage()
    {
        await Page.GetByRole(AriaRole.Link, new() { Name = "Login", Exact = true }).ClickAsync();
        Page.Url.Should().Contain("Login");
    }
}