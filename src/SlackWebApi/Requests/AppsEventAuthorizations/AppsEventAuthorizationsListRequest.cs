using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.AppsEventAuthorizations;

/// <summary>
/// The inputs of the AppsEventAuthorizationsList operation.
/// </summary>
public sealed record AppsEventAuthorizationsListRequest
{
    public required string EventContext { get; init; }

    public string? Cursor { get; init; }

    public int? Limit { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>authorizations:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
