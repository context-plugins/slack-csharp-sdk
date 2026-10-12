using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.OauthV2;

/// <summary>
/// The inputs of the OauthV2Access operation.
/// </summary>
public sealed record OauthV2AccessRequest
{
    /// <summary>
    /// The <c>code</c> param returned via the OAuth callback.
    /// </summary>
    public required string Code { get; init; }

    /// <summary>
    /// Issued when you created your application.
    /// </summary>
    public string? ClientId { get; init; }

    /// <summary>
    /// Issued when you created your application.
    /// </summary>
    public string? ClientSecret { get; init; }

    /// <summary>
    /// This must match the originally submitted URI (if one was sent).
    /// </summary>
    public string? RedirectUri { get; init; }

    public required ContentType ContentType { get; init; }
}
