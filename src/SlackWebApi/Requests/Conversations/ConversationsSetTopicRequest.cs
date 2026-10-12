using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsSetTopic operation.
/// </summary>
public sealed record ConversationsSetTopicRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Conversation to set the topic of
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// The new topic string. Does not support formatting or linkification.
    /// </summary>
    public string? Topic { get; init; }
}
