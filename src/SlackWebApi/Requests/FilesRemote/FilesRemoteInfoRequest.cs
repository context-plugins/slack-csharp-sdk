using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.FilesRemote;

/// <summary>
/// The inputs of the FilesRemoteInfo operation.
/// </summary>
public sealed record FilesRemoteInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>remote_files:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Specify a file by providing its ID.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// Creator defined GUID for the file.
    /// </summary>
    public string? ExternalId { get; init; }

    public required ContentType ContentType { get; init; }
}
