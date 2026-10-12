using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Conversations;

/// <summary>
/// The inputs of the ConversationsCreate operation.
/// </summary>
public sealed record ConversationsCreateRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>conversations:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Name of the public or private channel to create
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Create a private channel instead of a public one
    /// </summary>
    public bool? IsPrivate { get; init; }
}
