using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AdminConversations;

/// <summary>
/// The inputs of the AdminConversationsSetConversationPrefs operation.
/// </summary>
public sealed record AdminConversationsSetConversationPrefsRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>admin.conversations:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// The channel to set the prefs for
    /// </summary>
    public required string ChannelId { get; init; }

    /// <summary>
    /// The prefs for this channel in a stringified JSON format.
    /// </summary>
    public required string Prefs { get; init; }
}
