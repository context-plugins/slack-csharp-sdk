using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Files;

/// <summary>
/// The inputs of the FilesDelete operation.
/// </summary>
public sealed record FilesDeleteRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>files:write:user</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// ID of file to delete.
    /// </summary>
    public string? File { get; init; }
}
