using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Dialog;

/// <summary>
/// The inputs of the DialogOpen operation.
/// </summary>
public sealed record DialogOpenRequest
{
    /// <summary>
    /// The dialog definition. This must be a JSON-encoded string.
    /// </summary>
    public required string Dialog { get; init; }

    /// <summary>
    /// Exchange a trigger to post to the user.
    /// </summary>
    public required string TriggerId { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
