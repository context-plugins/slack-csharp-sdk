using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AppsPermissions;

/// <summary>
/// The inputs of the AppsPermissionsInfo operation.
/// </summary>
public sealed record AppsPermissionsInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public string? Token { get; init; }

    public required ContentType ContentType { get; init; }
}
