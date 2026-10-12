using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.ApiApi;

/// <summary>
/// The inputs of the ApiTest operation.
/// </summary>
public sealed record ApiTestRequest
{
    /// <summary>
    /// Error response to return
    /// </summary>
    public string? Error { get; init; }

    /// <summary>
    /// example property to return
    /// </summary>
    public string? Foo { get; init; }

    public required ContentType ContentType { get; init; }
}
