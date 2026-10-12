using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Auth;

/// <summary>
/// The inputs of the AuthRevoke operation.
/// </summary>
public sealed record AuthRevokeRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Setting this parameter to <c>1</c> triggers a _testing mode_ where the specified token will not actually be revoked.
    /// </summary>
    public bool? Test { get; init; }

    public required ContentType ContentType { get; init; }
}
