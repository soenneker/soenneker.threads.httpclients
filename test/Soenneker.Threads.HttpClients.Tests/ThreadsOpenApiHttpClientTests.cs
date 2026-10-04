using Soenneker.Threads.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Threads.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ThreadsOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IThreadsOpenApiHttpClient _httpclient;

    public ThreadsOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IThreadsOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
