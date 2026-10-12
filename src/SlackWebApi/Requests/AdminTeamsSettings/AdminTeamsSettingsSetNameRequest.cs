using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeamsSettings;

/// <summary>
/// The inputs of the AdminTeamsSettingsSetName operation.
/// </summary>
public sealed record AdminTeamsSettingsSetNameRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// ID for the workspace to set the name for.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// The new name of the workspace.
    /// </summary>
    public required string Name { get; init; }
}
