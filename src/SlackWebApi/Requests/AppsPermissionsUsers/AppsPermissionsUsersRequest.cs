using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AppsPermissionsUsers;

/// <summary>
/// The inputs of the AppsPermissionsUsersRequest operation.
/// </summary>
public sealed record AppsPermissionsUsersRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// A comma separated list of user scopes to request for
    /// </summary>
    public required string Scopes { get; init; }

    /// <summary>
    /// Token used to trigger the request
    /// </summary>
    public required string TriggerId { get; init; }

    /// <summary>
    /// The user this scope is being requested for
    /// </summary>
    public required string User { get; init; }

    public required ContentType ContentType { get; init; }
}
