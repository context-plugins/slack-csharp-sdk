using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Files;

/// <summary>
/// The inputs of the FilesSharedPublicUrl operation.
/// </summary>
public sealed record FilesSharedPublicUrlRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>files:write:user</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// File to share
    /// </summary>
    public string? File { get; init; }
}
