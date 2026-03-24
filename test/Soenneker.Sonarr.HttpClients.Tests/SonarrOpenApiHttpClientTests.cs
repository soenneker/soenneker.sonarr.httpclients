using Soenneker.Sonarr.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sonarr.HttpClients.Tests;

[Collection("Collection")]
public sealed class SonarrOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ISonarrOpenApiHttpClient _httpclient;

    public SonarrOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ISonarrOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
