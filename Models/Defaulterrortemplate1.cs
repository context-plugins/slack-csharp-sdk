using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// This method either only returns a brief _not OK_ response or a verbose schema is not available for this method.
/// </summary>
public record Defaulterrortemplate1
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
