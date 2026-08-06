using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// This method either only returns a brief _OK_ response or a verbose schema is not available for this method.
/// </summary>
public record Defaultsuccesstemplate
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
