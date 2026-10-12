using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversationsRestrictAccess;

/// <summary>
/// The inputs of the AdminConversationsRestrictAccessRemoveGroup operation.
/// </summary>
public sealed record AdminConversationsRestrictAccessRemoveGroupRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization.
    /// </summary>
    public required string TeamId { get; init; }

    /// <summary>
    /// The <see href="https://slack.com/help/articles/115001435788-Connect-identity-provider-groups-to-your-Enterprise-Grid-org">IDP Group</see> ID to remove from the private channel.
    /// </summary>
    public required string GroupId { get; init; }

    /// <summary>
    /// The channel to remove the linked group from.
    /// </summary>
    public required string ChannelId { get; init; }
}
