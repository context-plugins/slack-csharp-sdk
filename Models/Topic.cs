using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Slack.Models;

public record Topic
{
    [JsonPropertyName("creator")]
    [RegularExpression("^[UW][A-Z0-9]{8,}$|^$")]
    public required string Creator { get; init; }

    [JsonPropertyName("last_set")]
    public required int LastSet { get; init; }

    [JsonPropertyName("value")]
    public required string Value { get; init; }
}
