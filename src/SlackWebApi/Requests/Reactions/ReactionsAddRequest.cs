using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reactions;

/// <summary>
/// The inputs of the ReactionsAdd operation.
/// </summary>
public sealed record ReactionsAddRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reactions:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel where the message to add reaction to was posted.
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// Reaction (emoji) name.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Timestamp of the message to add reaction to.
    /// </summary>
    public required string Timestamp { get; init; }
}
