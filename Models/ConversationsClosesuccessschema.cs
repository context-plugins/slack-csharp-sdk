using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response conversations.close method
/// </summary>
public record ConversationsClosesuccessschema
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("already_closed")]
    public bool? AlreadyClosed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("no_op")]
    public bool? NoOp { get; init; }

    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
