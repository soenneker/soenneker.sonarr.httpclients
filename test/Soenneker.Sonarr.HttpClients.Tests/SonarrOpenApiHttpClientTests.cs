using Soenneker.Sonarr.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sonarr.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SonarrOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ISonarrOpenApiHttpClient _httpclient;

    public SonarrOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ISonarrOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
