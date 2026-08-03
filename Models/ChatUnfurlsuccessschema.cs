using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from chat.unfurl method
/// </summary>
public record ChatUnfurlsuccessschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
