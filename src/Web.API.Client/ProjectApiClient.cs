using TypedRest.Endpoints;
using TypedRest.Serializers;
using Web.API.Client;

namespace Web.API.Endpoints;

/// <summary>
/// Represents a client for the REST API Server.
/// </summary>

public class ProjectApiClient : EntryEndpoint
{
    public ProjectApiClient(HttpClient httpClient, string remoteApiUrl)
        : base(httpClient, new Uri(remoteApiUrl), serializer: new SystemTextJsonSerializer())
    {}

    public DomainEndpoint Domain => new(this);
}
