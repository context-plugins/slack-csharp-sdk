using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from dnd.endSnooze method
/// </summary>
public record DndEndSnoozeschema
{
    [JsonPropertyName("dnd_enabled")]
    public required bool DndEnabled { get; init; }

    [JsonPropertyName("next_dnd_end_ts")]
    public required int NextDndEndTs { get; init; }

    [JsonPropertyName("next_dnd_start_ts")]
    public required int NextDndStartTs { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonPropertyName("snooze_enabled")]
    public required bool SnoozeEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
