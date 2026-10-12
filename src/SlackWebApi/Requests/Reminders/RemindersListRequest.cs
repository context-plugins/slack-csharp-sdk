using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reminders;

/// <summary>
/// The inputs of the RemindersList operation.
/// </summary>
public sealed record RemindersListRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reminders:read</c>
    /// </summary>
    public string? Token { get; init; }

    public required ContentType ContentType { get; init; }
}
