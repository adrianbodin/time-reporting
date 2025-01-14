namespace TimeReporting.Integration.Tests.Infrastructure;

[Collection("Integration")]
public class IntegrationTestBase : PageTest
{
    private readonly IntegrationTestWebAppFactory Factory;
    protected string RootUrl;

    public IntegrationTestBase(IntegrationTestWebAppFactory factory)
    {
        Factory = factory;
        RootUrl = Factory.ServerAddress;
    }

    public override async Task DisposeAsync()
    {
        await Factory.ResetDatabaseAsync();
        await base.DisposeAsync();
    }
}