using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from chat.unfurl method
/// </summary>
public record ChatUnfurlsuccessschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
