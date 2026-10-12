using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Files;

/// <summary>
/// The inputs of the FilesUpload operation.
/// </summary>
public sealed record FilesUploadRequest
{
    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>files:write:user</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// File contents via <c>multipart/form-data</c>. If omitting this parameter, you must submit <c>content</c>.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// File contents via a POST variable. If omitting this parameter, you must provide a <c>file</c>.
    /// </summary>
    public string? Content { get; init; }

    /// <summary>
    /// A <see href="/types/file#file_types">file type</see> identifier.
    /// </summary>
    public string? Filetype { get; init; }

    /// <summary>
    /// Filename of file.
    /// </summary>
    public string? Filename { get; init; }

    /// <summary>
    /// Title of file.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// The message text introducing the file in specified <c>channels</c>.
    /// </summary>
    public string? InitialComment { get; init; }

    /// <summary>
    /// Comma-separated list of channel names or IDs where the file will be shared.
    /// </summary>
    public string? Channels { get; init; }

    /// <summary>
    /// Provide another message's <c>ts</c> value to upload this file as a reply. Never use a reply's <c>ts</c> value; use its parent instead.
    /// </summary>
    public double? ThreadTs { get; init; }
}
