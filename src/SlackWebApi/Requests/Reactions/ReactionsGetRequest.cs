using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reactions;

/// <summary>
/// The inputs of the ReactionsGet operation.
/// </summary>
public sealed record ReactionsGetRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reactions:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Channel where the message to get reactions for was posted.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// File to get reactions for.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// File comment to get reactions for.
    /// </summary>
    public string? FileComment { get; init; }

    /// <summary>
    /// If true always return the complete reaction list.
    /// </summary>
    public bool? Full { get; init; }

    /// <summary>
    /// Timestamp of the message to get reactions for.
    /// </summary>
    public string? Timestamp { get; init; }

    public required ContentType ContentType { get; init; }
}
