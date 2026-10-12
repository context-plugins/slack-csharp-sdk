using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversationsRestrictAccess;

/// <summary>
/// The inputs of the AdminConversationsRestrictAccessListGroups operation.
/// </summary>
public sealed record AdminConversationsRestrictAccessListGroupsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required string ChannelId { get; init; }

    /// <summary>
    /// The workspace where the channel exists. This argument is required for channels only tied to one workspace, and optional for channels that are shared across an organization.
    /// </summary>
    public string? TeamId { get; init; }

    public required ContentType ContentType { get; init; }
}
