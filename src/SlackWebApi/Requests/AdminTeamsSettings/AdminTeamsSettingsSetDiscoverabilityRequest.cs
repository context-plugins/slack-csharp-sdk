using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeamsSettings;

/// <summary>
/// The inputs of the AdminTeamsSettingsSetDiscoverability operation.
/// </summary>
public sealed record AdminTeamsSettingsSetDiscoverabilityRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The ID of the workspace to set discoverability on.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// This workspace's discovery setting. It must be set to one of <c>open</c>, <c>invite_only</c>, <c>closed</c>, or <c>unlisted</c>.
    /// </summary>
    public required string Discoverability { get; init; }
}
