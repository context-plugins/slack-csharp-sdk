using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminUsergroups;

/// <summary>
/// The inputs of the AdminUsergroupsAddChannels operation.
/// </summary>
public sealed record AdminUsergroupsAddChannelsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.usergroups:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// ID of the IDP group to add default channels for.
    /// </summary>
    public required string UsergroupId { get; init; }

    /// <summary>
    /// Comma separated string of channel IDs.
    /// </summary>
    public required string ChannelIds { get; init; }

    /// <summary>
    /// The workspace to add default channels in.
    /// </summary>
    public string? TeamId { get; init; }
}
