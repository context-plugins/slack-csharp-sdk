using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Views;

/// <summary>
/// The inputs of the ViewsPublish operation.
/// </summary>
public sealed record ViewsPublishRequest
{
    /// <summary>
    /// <c>id</c> of the user you want publish a view to.
    /// </summary>
    public required string UserId { get; init; }

    /// <summary>
    /// A <see href="/reference/surfaces/views">view payload</see>. This must be a JSON-encoded string.
    /// </summary>
    public required string View { get; init; }

    /// <summary>
    /// A string that represents view state to protect against possible race conditions.
    /// </summary>
    public string? Hash { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
