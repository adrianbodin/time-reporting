using TimeReporting.Integration.Tests.Infrastructure;

using System.Net;
using TimeReporting.Integration.Tests.Helpers;
using Xunit.Abstractions;

namespace TimeReporting.Integration.Tests.Pages.Report;

public class CreatePageTests : IntegrationTestBase
{
    public CreatePageTests(IntegrationTestWebAppFactory factory) : base(factory)
    {
    }

}