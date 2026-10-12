using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatGetPermalink operation.
/// </summary>
public sealed record ChatGetPermalinkRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// The ID of the conversation or channel containing the message
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// A message's <c>ts</c> value, uniquely identifying it within a channel
    /// </summary>
    public required string MessageTs { get; init; }

    public required ContentType ContentType { get; init; }
}
