using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Files;

/// <summary>
/// The inputs of the FilesRevokePublicUrl operation.
/// </summary>
public sealed record FilesRevokePublicUrlRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>files:write:user</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// File to revoke
    /// </summary>
    public string? File { get; init; }
}
