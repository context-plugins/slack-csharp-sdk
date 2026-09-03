using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

public record Errorsisreturnedwhenanerrorassociatesanuser
{
    [JsonPropertyName("error")]
    public required ConversationsInviteErrorEnum Error { get; init; }

    [JsonPropertyName("ok")]
    public string Ok { get; } = "False";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public string? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
