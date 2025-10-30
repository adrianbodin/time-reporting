using Renci.SshNet;
using EntreprenadPro.Integration.Tests.Helpers;
using EntreprenadPro.Integration.Tests.Infrastructure;

namespace EntreprenadPro.Integration.Tests;

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
    public async Task Admin_Should_Be_Able_To_Navigate_To_Account_Page()
    {
        await Page.AuthenticateAdminAsync(RootUrl);
        await Page.GotoAsync($"{RootUrl}Account/Manage");
        Assert.Contains("Account/Manage", Page.Url);
    }

    [Fact]
    public async Task Admin_Should_Be_Able_To_Navigate_To_Account_Page_Through_Nav()
    {
        await Page.AuthenticateAdminAsync(RootUrl);

        await Page
            .GetByRole(AriaRole.Navigation)
            .GetByTestId("AccountLink")
            .ClickAsync();

        await Page.WaitForUnpoly();

        Assert.Contains("Account/Manage", Page.Url);
    }

    [Fact]
    public async Task Admin_Should_Be_Able_To_Navigate_To_Projects_Page_Through_Nav()
    {
        await Page.AuthenticateAdminAsync(RootUrl);

        await Page
            .GetByRole(AriaRole.Navigation)
            .GetByTestId("ProjectsLink")
            .ClickAsync();

        await Page.WaitForUnpoly();

        Assert.Contains("Projects", Page.Url);
    }
}