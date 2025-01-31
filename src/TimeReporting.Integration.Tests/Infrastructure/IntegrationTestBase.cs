namespace TimeReporting.Integration.Tests.Infrastructure;

[Collection("Integration")]
public class IntegrationTestBase : IAsyncLifetime
{
    private readonly IntegrationTestWebAppFactory Factory;
    protected string RootUrl;
    protected IPage Page { get; set; }

    public IntegrationTestBase(IntegrationTestWebAppFactory factory)
    {
        Factory = factory;
        RootUrl = Factory.ServerAddress;
    }

    public async Task InitializeAsync()
    {
        var context = await Factory.Browser.NewContextAsync();
        Page = await context.NewPageAsync();
    }

    public async Task DisposeAsync()
    {
        await Factory.ResetDatabaseAsync();
    }
}