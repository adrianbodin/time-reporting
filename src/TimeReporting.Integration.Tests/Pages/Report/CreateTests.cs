using TimeReporting.Integration.Tests.Infrastructure;

using System.Net;
using TimeReporting.Integration.Tests.Helpers;
using Xunit.Abstractions;

namespace TimeReporting.Integration.Tests.Pages.Report;

public class CreatePageTests : IntegrationTestBase
{
    private readonly ITestOutputHelper _testOutputHelper;

    public CreatePageTests(IntegrationTestWebAppFactory factory, ITestOutputHelper testOutputHelper) : base(factory)
    {
        _testOutputHelper = testOutputHelper;
    }
    //write more tests like this for the /Report/Create page

    [Fact]
    public async Task CreatePage_WhenUserIsNotAuthenticatedThenUserIsRedirectedToLoginPage()
    {
        await Page.GotoAsync($"{RootUrl}Report/Create");
        Assert.Contains("Login", Page.Url);
    }

    [Fact]
    public async Task CreatePage_WhenUserIsAuthenticatedThenUserCanAccessPage()
    {
        await Page.AuthenticateAdminAsync(RootUrl);

        await Page.GotoAsync($"{RootUrl}Reports/Create");

        Assert.Contains("Report/Create", Page.Url);
    }

}