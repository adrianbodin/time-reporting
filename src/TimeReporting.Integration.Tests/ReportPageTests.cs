using TimeReporting.Integration.Tests.Helpers;
using TimeReporting.Integration.Tests.Infrastructure;

namespace TimeReporting.Integration.Tests;

public class ReportPageTests : IntegrationTestBase
{
    public ReportPageTests(IntegrationTestWebAppFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task WhenUserVisitReportPageTheDateInputShouldBeTodaysDate()
    {
        await Page.GotoAsync($"{RootUrl}report");
        var dateInput = await Page.GetByTestId("date-input").GetAttributeAsync("value");
        var date = DateTime.Parse(dateInput);
        Assert.True((date - DateTime.Today).Duration() < TimeSpan.FromSeconds(60));
    }

    [Fact]
    public async Task WhenUserChangeDateTheCardsWithThatDateShouldBeFetchedFromTheServer()
    {
        await Page.GotoAsync($"{RootUrl}report");

        await Page.GetByTestId("date-input").FillAsync("2024-01-19");

        await Page.WaitForHtmx();

        var reportCardDate = await Page.GetByTestId("report-date").First.InnerTextAsync();

        Assert.Equivalent(reportCardDate, "19");
    }

    [Fact]
    public async Task WhenAdminVisitReportPageThenAdminCanSeeAllReportCards()
    {
        await Page.AuthenticateAdminAsync(RootUrl);
        await Page.GotoAsync($"{RootUrl}report");

        var test = await Page.GetByTestId("admin-check").First.InnerTextAsync();

        Assert.Equivalent(test, "I am a admin!!!");
    }
}