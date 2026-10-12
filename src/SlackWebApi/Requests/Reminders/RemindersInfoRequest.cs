using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.Reminders;

/// <summary>
/// The inputs of the RemindersInfo operation.
/// </summary>
public sealed record RemindersInfoRequest
{
    /// <summary>
    /// Authentication token. Requires scope: <c>reminders:read</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// The ID of the reminder
    /// </summary>
    public string? Reminder { get; init; }

    public required ContentType ContentType { get; init; }
}
