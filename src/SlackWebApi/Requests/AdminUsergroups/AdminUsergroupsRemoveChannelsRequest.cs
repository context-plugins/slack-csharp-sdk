using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsergroups;

/// <summary>
/// The inputs of the AdminUsergroupsRemoveChannels operation.
/// </summary>
public sealed record AdminUsergroupsRemoveChannelsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.usergroups:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// ID of the IDP Group
    /// </summary>
    public required string UsergroupId { get; init; }

    /// <summary>
    /// Comma-separated string of channel IDs
    /// </summary>
    public required string ChannelIds { get; init; }
}
