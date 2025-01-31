using DotNet.Testcontainers.Builders;
using TimeReporting.Integration.Tests.Helpers;
using TimeReporting.Integration.Tests.Infrastructure;

namespace TimeReporting.Integration.Tests;

public class NavigationTests : IntegrationTestBase
{
    public NavigationTests(IntegrationTestWebAppFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task When_User_Is_Not_Authenticated_Then_User_Is_Redirected_To_LoginPage()
    {
        await Page.GotoAsync($"{RootUrl}");

        Assert.Contains("Login", Page.Url);
    }

    [Fact]
    public async Task Admin_Should_Be_Able_To_Navigate_To_Profile_Page()
    {
        await Page.AuthenticateAdminAsync(RootUrl);
        await Page.GotoAsync($"{RootUrl}Profile");
        Assert.Contains("Profile", Page.Url);
    }

    [Fact]
    public async Task Admin_Should_Be_Able_To_Navigate_To_Profile_Page_Through_Nav()
    {
        await Page.AuthenticateAdminAsync(RootUrl);

        await Page
            .GetByRole(AriaRole.Navigation)
            .GetByTestId("ProfilePageLink")
            .ClickAsync();

        await Page.WaitForUnpoly();

        Assert.Contains("Manage", Page.Url);
    }
}