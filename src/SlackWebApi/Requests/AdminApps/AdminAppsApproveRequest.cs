using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminApps;

/// <summary>
/// The inputs of the AdminAppsApprove operation.
/// </summary>
public sealed record AdminAppsApproveRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.apps:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The id of the app to approve.
    /// </summary>
    public string? AppId { get; init; }

    /// <summary>
    /// The id of the request to approve.
    /// </summary>
    public string? RequestId { get; init; }

    public string? TeamId { get; init; }
}
