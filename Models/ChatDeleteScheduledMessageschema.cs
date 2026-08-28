using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from chat.deleteScheduledMessage method
/// </summary>
public record ChatDeleteScheduledMessageschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
