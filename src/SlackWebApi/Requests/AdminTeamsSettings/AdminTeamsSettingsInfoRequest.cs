using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeamsSettings;

/// <summary>
/// The inputs of the AdminTeamsSettingsInfo operation.
/// </summary>
public sealed record AdminTeamsSettingsInfoRequest
{
    public required string TeamId { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
