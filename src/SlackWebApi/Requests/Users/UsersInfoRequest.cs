using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Users;

/// <summary>
/// The inputs of the UsersInfo operation.
/// </summary>
public sealed record UsersInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>users:read</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Set this to <c>true</c> to receive the locale for this user. Defaults to <c>false</c>
    /// </summary>
    public bool? IncludeLocale { get; init; }

    /// <summary>
    /// User to get info on
    /// </summary>
    public string? User { get; init; }

    public required ContentType ContentType { get; init; }
}
