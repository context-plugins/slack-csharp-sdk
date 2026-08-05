using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response of admin.conversations.search
/// </summary>
public record AdminConversationsSearchschema
{
    [JsonPropertyName("channels")]
    public required IReadOnlyList<ChannelObject> Channels { get; init; }

    [JsonPropertyName("next_cursor")]
    public required string NextCursor { get; init; }
}
