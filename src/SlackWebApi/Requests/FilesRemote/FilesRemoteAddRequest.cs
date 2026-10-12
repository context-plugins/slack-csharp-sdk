using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.FilesRemote;

/// <summary>
/// The inputs of the FilesRemoteAdd operation.
/// </summary>
public sealed record FilesRemoteAddRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>remote_files:write</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Creator defined GUID for the file.
    /// </summary>
    public string? ExternalId { get; init; }

    /// <summary>
    /// Title of the file being shared.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// type of file
    /// </summary>
    public string? Filetype { get; init; }

    /// <summary>
    /// URL of the remote file.
    /// </summary>
    public string? ExternalUrl { get; init; }

    /// <summary>
    /// Preview of the document via <c>multipart/form-data</c>.
    /// </summary>
    public string? PreviewImage { get; init; }

    /// <summary>
    /// A text file (txt, pdf, doc, etc.) containing textual search terms that are used to improve discovery of the remote file.
    /// </summary>
    public string? IndexableFileContents { get; init; }
}
