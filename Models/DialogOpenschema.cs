using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from dialog.open method
/// </summary>
public record DialogOpenschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
