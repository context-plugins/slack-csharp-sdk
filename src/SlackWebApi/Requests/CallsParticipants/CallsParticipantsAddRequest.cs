using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.CallsParticipants;

/// <summary>
/// The inputs of the CallsParticipantsAdd operation.
/// </summary>
public sealed record CallsParticipantsAddRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>calls:write</c>
    /// </summary>
    public required string Token { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// <c>id</c> returned by the <see href="/methods/calls.add"><c>calls.add</c></see> method.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The list of users to add as participants in the Call. <see href="/apis/calls#users">Read more on how to specify users here</see>.
    /// </summary>
    public required string Users { get; init; }
}
