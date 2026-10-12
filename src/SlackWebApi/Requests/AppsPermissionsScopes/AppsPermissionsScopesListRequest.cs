using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AppsPermissionsScopes;

/// <summary>
/// The inputs of the AppsPermissionsScopesList operation.
/// </summary>
public sealed record AppsPermissionsScopesListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
