using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminTeamsSettings;

/// <summary>
/// The inputs of the AdminTeamsSettingsSetDefaultChannels operation.
/// </summary>
public sealed record AdminTeamsSettingsSetDefaultChannelsRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.teams:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// ID for the workspace to set the default channel for.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// An array of channel IDs.
    /// </summary>
    public required string ChannelIds { get; init; }
}
