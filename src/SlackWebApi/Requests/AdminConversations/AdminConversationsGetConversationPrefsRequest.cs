using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsGetConversationPrefs operation.
/// </summary>
public sealed record AdminConversationsGetConversationPrefsRequest
{
    /// <summary>
    /// The channel to get preferences for.
    /// </summary>
    public required string ChannelId { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
