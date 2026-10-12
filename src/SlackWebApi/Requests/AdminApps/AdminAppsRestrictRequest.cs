using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminApps;

/// <summary>
/// The inputs of the AdminAppsRestrict operation.
/// </summary>
public sealed record AdminAppsRestrictRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.apps:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The id of the app to restrict.
    /// </summary>
    public string? AppId { get; init; }

    /// <summary>
    /// The id of the request to restrict.
    /// </summary>
    public string? RequestId { get; init; }

    public string? TeamId { get; init; }
}
