using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Files;

/// <summary>
/// The inputs of the FilesList operation.
/// </summary>
public sealed record FilesListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>files:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Filter files created by a single user.
    /// </summary>
    public string? User { get; init; }

    /// <summary>
    /// Filter files appearing in a specific channel, indicated by its ID.
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// Filter files created after this timestamp (inclusive).
    /// </summary>
    public double? TsFrom { get; init; }

    /// <summary>
    /// Filter files created before this timestamp (inclusive).
    /// </summary>
    public double? TsTo { get; init; }

    /// <summary>
    /// Filter files by type (<see href="#file_types">see below</see>). You can pass multiple values in the types argument, like <c>types=spaces,snippets</c>.The default value is <c>all</c>, which does not filter the list.
    /// </summary>
    public string? Types { get; init; }

    public string? Count { get; init; }

    public string? Page { get; init; }

    /// <summary>
    /// Show truncated file info for files hidden due to being too old, and the team who owns the file being over the file limit.
    /// </summary>
    public bool? ShowFilesHiddenByLimit { get; init; }

    public required ContentType ContentType { get; init; }
}
