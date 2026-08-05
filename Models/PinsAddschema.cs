using System.Text.Json.Serialization;

namespace Slack.Models;

/// <summary>
/// Schema for successful response from pins.add method
/// </summary>
public record PinsAddschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
