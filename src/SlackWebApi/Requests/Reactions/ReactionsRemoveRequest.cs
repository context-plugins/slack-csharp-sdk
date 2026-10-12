using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reactions;

/// <summary>
/// The inputs of the ReactionsRemove operation.
/// </summary>
public sealed record ReactionsRemoveRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reactions:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Reaction (emoji) name.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// File to remove reaction from.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// File comment to remove reaction from.
    /// </summary>
    public string? FileComment { get; init; }

    /// <summary>
    /// Channel where the message to remove reaction from was posted.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Timestamp of the message to remove reaction from.
    /// </summary>
    public string? Timestamp { get; init; }
}
