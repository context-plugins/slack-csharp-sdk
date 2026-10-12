using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Calls;

/// <summary>
/// The inputs of the CallsEnd operation.
/// </summary>
public sealed record CallsEndRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>calls:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// <c>id</c> returned when registering the call using the <see href="/methods/calls.add"><c>calls.add</c></see> method.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Call duration in seconds
    /// </summary>
    public int? Duration { get; init; }
}
