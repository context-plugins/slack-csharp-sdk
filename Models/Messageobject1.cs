using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Messageobject1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attachments")]
    public IReadOnlyList<object>? Attachments { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blocks")]
    public object? Blocks { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }
}
