using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record Purpose
{
    [JsonPropertyName("creator")]
    [RegularExpression("^[UW][A-Z0-9]{8,}$|^$")]
    public required string Creator { get; init; }

    [JsonPropertyName("last_set")]
    public required int LastSet { get; init; }

    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
