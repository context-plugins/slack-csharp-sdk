using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Rtm;

/// <summary>
/// The inputs of the RtmConnect operation.
/// </summary>
public sealed record RtmConnectRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>rtm:stream</c>
    /// </summary>
    public required string Token { get; init; }

    /// <summary>
    /// Batch presence deliveries via subscription. Enabling changes the shape of <c>presence_change</c> events.
    /// </summary>
    public bool? BatchPresenceAware { get; init; }

    /// <summary>
    /// Only deliver presence events when requested by subscription
    /// </summary>
    public bool? PresenceSub { get; init; }

    public required ContentType ContentType { get; init; }
}
