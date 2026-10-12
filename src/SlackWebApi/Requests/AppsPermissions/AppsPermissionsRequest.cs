using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AppsPermissions;

/// <summary>
/// The inputs of the AppsPermissionsRequest operation.
/// </summary>
public sealed record AppsPermissionsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// A comma separated list of scopes to request for
    /// </summary>
    public required string Scopes { get; init; }

    /// <summary>
    /// Token used to trigger the permissions API
    /// </summary>
    public required string TriggerId { get; init; }

    public required ContentType ContentType { get; init; }
}
