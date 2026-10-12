using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.FilesRemote;

/// <summary>
/// The inputs of the FilesRemoteShare operation.
/// </summary>
public sealed record FilesRemoteShareRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>remote_files:share</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Specify a file registered with Slack by providing its ID. Either this field or <c>external_id</c> or both are required.
    /// </summary>
    public string? File { get; init; }

    /// <summary>
    /// The globally unique identifier (GUID) for the file, as set by the app registering the file with Slack.  Either this field or <c>file</c> or both are required.
    /// </summary>
    public string? ExternalId { get; init; }

    /// <summary>
    /// Comma-separated list of channel IDs where the file will be shared.
    /// </summary>
    public string? Channels { get; init; }

    public required ContentType ContentType { get; init; }
}
