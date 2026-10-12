using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Oauth;

/// <summary>
/// The inputs of the OauthAccess operation.
/// </summary>
public sealed record OauthAccessRequest
{
    /// <summary>
    /// Issued when you created your application.
    /// </summary>
    public string? ClientId { get; init; }

    /// <summary>
    /// Issued when you created your application.
    /// </summary>
    public string? ClientSecret { get; init; }

    /// <summary>
    /// The <c>code</c> param returned via the OAuth callback.
    /// </summary>
    public string? Code { get; init; }

    /// <summary>
    /// This must match the originally submitted URI (if one was sent).
    /// </summary>
    public string? RedirectUri { get; init; }

    /// <summary>
    /// Request the user to add your app only to a single channel. Only valid with a <see href="https://api.slack.com/legacy-workspace-apps">legacy workspace app</see>.
    /// </summary>
    public bool? SingleChannel { get; init; }

    public required ContentType ContentType { get; init; }
}
