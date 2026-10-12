using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeamsSettings;

/// <summary>
/// The inputs of the AdminTeamsSettingsSetIcon operation.
/// </summary>
public sealed record AdminTeamsSettingsSetIconRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Image URL for the icon
    /// </summary>
    public required string ImageUrl { get; init; }

    /// <summary>
    /// ID for the workspace to set the icon for.
    /// </summary>
    public required string TeamId { get; init; }
}
