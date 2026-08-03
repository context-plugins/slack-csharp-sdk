using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// This method either only returns a brief _not OK_ response or a verbose schema is not available for this method.
/// </summary>
public record Defaulterrortemplate1
{
    [JsonPropertyName("ok")]
    public required Ok Ok { get; init; }
}
