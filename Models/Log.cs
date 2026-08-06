using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

public record Log
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("admin_app_id")]
    [RegularExpression("^A[A-Z0-9]{1,}$")]
    public string? AdminAppId { get; init; }

    [JsonPropertyName("app_id")]
    [RegularExpression("^A[A-Z0-9]{1,}$")]
    public required string AppId { get; init; }

    [JsonPropertyName("app_type")]
    public required string AppType { get; init; }

    [JsonPropertyName("change_type")]
    public required string ChangeType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    [RegularExpression("^[CGD][A-Z0-9]{8,}$")]
    public string? Channel { get; init; }

    [JsonPropertyName("date")]
    public required string Date { get; init; }

    [JsonPropertyName("scope")]
    public required string Scope { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_id")]
    public string? ServiceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_type")]
    public string? ServiceType { get; init; }

    [JsonPropertyName("user_id")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string UserId { get; init; }

    [JsonPropertyName("user_name")]
    public required string UserName { get; init; }
}
