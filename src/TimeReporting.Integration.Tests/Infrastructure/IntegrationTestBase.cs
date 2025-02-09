namespace TimeReporting.Integration.Tests.Infrastructure;

[Collection("Integration")]
public class IntegrationTestBase : IAsyncLifetime
{
    private readonly IntegrationTestWebAppFactory _factory;
    private IBrowserContext _context;
    protected string RootUrl;
    protected IPage Page { get; set; }

    public IntegrationTestBase(IntegrationTestWebAppFactory factory)
    {
        _factory = factory;
        RootUrl = _factory.ServerAddress;
    }

    public async Task InitializeAsync()
    {
        _context = await _factory.Browser.NewContextAsync();
        Page = await _context.NewPageAsync();
    }

    public async Task DisposeAsync()
    {
        if (Page != null)
        {
            await Page.CloseAsync();
        }
        if (_context != null)
        {
            await _context.CloseAsync();
        }
        await _factory.ResetDatabaseAsync();
    }
}