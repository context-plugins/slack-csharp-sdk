using System.Text.Json.Serialization;

namespace Slack.Models;

public record Shares
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("private")]
    public object? Private { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public")]
    public object? Public { get; init; }
}
