using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Login
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    [JsonPropertyName("date_first")]
    public required int DateFirst { get; init; }

    [JsonPropertyName("date_last")]
    public required int DateLast { get; init; }

    [JsonPropertyName("ip")]
    public required string? Ip { get; init; }

    [JsonPropertyName("isp")]
    public required string? Isp { get; init; }

    [JsonPropertyName("region")]
    public required string? Region { get; init; }

    [JsonPropertyName("user_agent")]
    public required string UserAgent { get; init; }

    [JsonPropertyName("user_id")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string UserId { get; init; }

    [JsonPropertyName("username")]
    public required string Username { get; init; }
}
