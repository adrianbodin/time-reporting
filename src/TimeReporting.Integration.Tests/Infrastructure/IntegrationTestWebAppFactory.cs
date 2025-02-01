using System.Data.Common;
using DotNet.Testcontainers.Containers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using Respawn;
using Testcontainers.PostgreSql;
using TimeReporting.Data;
using TimeReporting.Models;

namespace TimeReporting.Integration.Tests.Infrastructure;

public class IntegrationTestWebAppFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private readonly PostgreSqlContainer _container = new PostgreSqlBuilder()
        .WithImage("postgres:latest")
        .WithDatabase("time_reporting_test_db")
        .WithUsername("postgres")
        .WithPassword("postgres")
        .WithReuse(true)
        .WithName("TimeReporting")
        .Build();

    private AppDbContext Db { get; set; } = null!;
    private DbConnection _dbConnection = default!;
    private Respawner _respawner = null!;
    private IHost _host = default!;
    private IPlaywright PlaywrightInstance { get; set; } = default!;
    public IBrowser Browser { get; set; } = default!;

    public string ServerAddress
    {
        get
        {
            if (_host is null)
            {
                using var _ = CreateDefaultClient();
            }
            return ClientOptions.BaseAddress.ToString();
        }
    }

    public IntegrationTestWebAppFactory() {}

    protected override IHost CreateHost(IHostBuilder builder)
    {
        var testHost = builder.Build();

        builder.ConfigureWebHost(webHostBuilder =>
        {
            webHostBuilder.UseKestrel();
        });

        _host = builder.Build();
        _host.Start();

        var server = _host.Services.GetRequiredService<IServer>();
        var addresses = server.Features.Get<IServerAddressesFeature>();

        ClientOptions.BaseAddress = addresses!.Addresses.Select(a => new Uri(a)).Last();

        testHost.Start();
        return testHost;
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));

            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(_container.GetConnectionString());
            });

            using var scope = services.BuildServiceProvider().CreateScope();
            var serviceProvider = scope.ServiceProvider;
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
        });
    }


    public async Task InitializeAsync()
    {
        await _container.StartAsync();

        Db = Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
        _dbConnection = Db.Database.GetDbConnection();
        await _dbConnection.OpenAsync();

        _respawner = await Respawner.CreateAsync(_dbConnection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.Postgres,
            SchemasToInclude = new[] { "public" }
        });

        PlaywrightInstance = await Playwright.CreateAsync();
        Browser = await PlaywrightInstance.Chromium.LaunchAsync();
    }

    public async Task ResetDatabaseAsync()
    {
        using (var conn = new NpgsqlConnection(_container.GetConnectionString()))
        {
            await conn.OpenAsync();

            await _respawner.ResetAsync(conn);
        }

        using var scope = Services.CreateScope();
        var serviceProvider = scope.ServiceProvider;

        var context = serviceProvider.GetRequiredService<AppDbContext>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<Employee>>();

        await SeedData.SeedRolesAndAdminUserAsync(context, roleManager, userManager);
    }

    public new async Task DisposeAsync()
    {
        await Browser.DisposeAsync();
        await _dbConnection.CloseAsync();
        //await _container.DisposeAsync();
    }
}