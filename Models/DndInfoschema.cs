using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from dnd.info method
/// </summary>
public record DndInfoschema
{
    [JsonPropertyName("dnd_enabled")]
    public required bool DndEnabled { get; init; }

    [JsonPropertyName("next_dnd_end_ts")]
    public required int NextDndEndTs { get; init; }

    [JsonPropertyName("next_dnd_start_ts")]
    public required int NextDndStartTs { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snooze_enabled")]
    public bool? SnoozeEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snooze_endtime")]
    public int? SnoozeEndtime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snooze_remaining")]
    public int? SnoozeRemaining { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
