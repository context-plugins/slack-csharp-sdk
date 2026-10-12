using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Calls;

/// <summary>
/// The inputs of the CallsInfo operation.
/// </summary>
public sealed record CallsInfoRequest
{
    /// <summary>
    /// <c>id</c> of the Call returned by the <see href="/methods/calls.add"><c>calls.add</c></see> method.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>calls:read</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }
}
