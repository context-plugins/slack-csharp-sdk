using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.open method when opening channels, ims, mpims
/// </summary>
public record ConversationsOpensuccessschema1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("already_open")]
    public bool? AlreadyOpen { get; init; }

    [JsonPropertyName("channel")]
    public required object Channel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("no_op")]
    public bool? NoOp { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
