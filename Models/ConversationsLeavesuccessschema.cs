using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from conversations.leave method
/// </summary>
public record ConversationsLeavesuccessschema
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("not_in_channel")]
    public bool? NotInChannel { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
