using SlackWebApi.Models.Enums;

namespace SlackWebApi.Requests.ChatScheduledMessages;

/// <summary>
/// The inputs of the ChatScheduledMessagesList operation.
/// </summary>
public sealed record ChatScheduledMessagesListRequest
{
    /// <summary>
    /// The channel of the scheduled messages
    /// </summary>
    public string? Channel { get; init; }

    /// <summary>
    /// A UNIX timestamp of the latest value in the time range
    /// </summary>
    public double? Latest { get; init; }

    /// <summary>
    /// A UNIX timestamp of the oldest value in the time range
    /// </summary>
    public double? Oldest { get; init; }

    /// <summary>
    /// Maximum number of original entries to return.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// For pagination purposes, this is the <c>cursor</c> value returned from a previous call to <c>chat.scheduledmessages.list</c> indicating where you want to start this call from.
    /// </summary>
    public string? Cursor { get; init; }

    public required ContentType ContentType { get; init; }

    /// <summary>
    /// Authentication token. Requires scope: <c>none</c>
    /// </summary>
    public string? Token { get; init; }
}
