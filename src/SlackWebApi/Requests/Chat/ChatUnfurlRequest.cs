using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Chat;

/// <summary>
/// The inputs of the ChatUnfurl operation.
/// </summary>
public sealed record ChatUnfurlRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>links:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Channel ID of the message
    /// </summary>
    public required string Channel { get; init; }

    /// <summary>
    /// Timestamp of the message to add unfurl behavior to.
    /// </summary>
    public required string Ts { get; init; }

    /// <summary>
    /// URL-encoded JSON map with keys set to URLs featured in the the message, pointing to their unfurl blocks or message attachments.
    /// </summary>
    public string? Unfurls { get; init; }

    /// <summary>
    /// Provide a simply-formatted string to send as an ephemeral message to the user as invitation to authenticate further and enable full unfurling behavior
    /// </summary>
    public string? UserAuthMessage { get; init; }

    /// <summary>
    /// Set to <c>true</c> or <c>1</c> to indicate the user must install your Slack app to trigger unfurls for this domain
    /// </summary>
    public bool? UserAuthRequired { get; init; }

    /// <summary>
    /// Send users to this custom URL where they will complete authentication in your app to fully trigger unfurling. Value should be properly URL-encoded.
    /// </summary>
    public string? UserAuthUrl { get; init; }
}
