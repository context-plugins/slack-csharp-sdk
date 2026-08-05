using System.Text.Json.Serialization;
using Slack.Models.Enums;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from conversations.leave method
/// </summary>
public record ConversationsLeavesuccessschema1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("not_in_channel")]
    public bool? NotInChannel { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
