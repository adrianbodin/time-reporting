using EntreprenadPro.Data;
using EntreprenadPro.Models;
using EntreprenadPro.Pages.Tid;
using EntreprenadPro.Unit.Tests.Infrastructure;

namespace EntreprenadPro.Unit.Tests.Pages.Reports;

public class CreateTests : RazorPageTest
{
    [Theory]
    [InlineData(2, 30, 2.5)]
    [InlineData(1, 15, 1.5)]
    [InlineData(0, 1, 0.5)]
    [InlineData(1, 45, 2)]
    public async Task Hours_Should_Be_Set_From_Query_Parameters_Correctly(int hours, int minutes, double expectedHours)
    {
        // Arrange
        var mockContext = Substitute.For<IAppDbContext>();
        var emptyProjects = new List<Project>().AsQueryable().BuildMockDbSet();
        var emptyWorkTypes = new List<WorkType>().AsQueryable().BuildMockDbSet();

        mockContext.Projects.Returns(emptyProjects);
        mockContext.WorkTypes.Returns(emptyWorkTypes);

        var createModel = SetupPage(new Skapa(mockContext));

        // Act
        await createModel.OnGet(hours, minutes);

        // Assert
        Assert.Equal(expectedHours, createModel.NewEntry.Hours);
        Assert.Equal("New Time Entry", createModel.ViewData["Title"]);
    }
}