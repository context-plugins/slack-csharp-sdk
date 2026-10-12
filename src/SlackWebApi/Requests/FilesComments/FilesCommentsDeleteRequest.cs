using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.FilesComments;

/// <summary>
/// The inputs of the FilesCommentsDelete operation.
/// </summary>
public sealed record FilesCommentsDeleteRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>files:write:user</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// File to delete a comment from.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// The comment to delete.
    /// </summary>
    public string? Id { get; init; }
}
