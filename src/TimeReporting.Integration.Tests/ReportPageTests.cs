using TimeReporting.Integration.Tests.Helpers;
using TimeReporting.Integration.Tests.Infrastructure;

namespace TimeReporting.Integration.Tests;

public class ReportPageTests : IntegrationTestBase
{
    public ReportPageTests(IntegrationTestWebAppFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task When_User_Visit_Report_Page_The_Date_Input_Should_Be_Todays_Date()
    {
        await Page.AuthenticateAdminAsync(RootUrl);
        await Page.GotoAsync($"{RootUrl}Reports");
        var dateInput = await Page.GetByTestId("date-input").GetAttributeAsync("value");
        var date = DateTime.Parse(dateInput);
        Assert.True((date - DateTime.Today).Duration() < TimeSpan.FromSeconds(60));
    }
}