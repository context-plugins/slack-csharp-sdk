using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Apps;

/// <summary>
/// The inputs of the AppsUninstall operation.
/// </summary>
public sealed record AppsUninstallRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Issued when you created your application.
    /// </summary>
    public string? ClientId { get; init; }

    /// <summary>
    /// Issued when you created your application.
    /// </summary>
    public string? ClientSecret { get; init; }

    public required ContentType ContentType { get; init; }
}
