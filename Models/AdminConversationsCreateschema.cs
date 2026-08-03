using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response of admin.conversations.create
/// </summary>
public record AdminConversationsCreateschema
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel_id")]
    [RegularExpression("^[C][A-Z0-9]{2,}$")]
    public string? ChannelId { get; init; }

    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
