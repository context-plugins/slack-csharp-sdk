using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from dialog.open method
/// </summary>
public record DialogOpenschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
