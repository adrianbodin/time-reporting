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
        date.Should().BeCloseTo(DateTime.Today, TimeSpan.FromSeconds(60));
    }

    [Fact]
    public async Task WhenUserChangeDateTheCardsWithThatDateShouldBeFetchedFromTheServer()
    {
        await Page.GotoAsync($"{RootUrl}report");

        await Page.GetByTestId("date-input").FillAsync("2024-01-19");

        await Page.WaitForHtmx();

        var reportCardDate = await Page.GetByTestId("report-date").First.InnerTextAsync();

        reportCardDate.Should().Be("19");
    }
}