using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Models;

namespace Slack.Models;

public record SubteamUsergroupObject
{
    [JsonPropertyName("auto_provision")]
    public required bool AutoProvision { get; init; }

    [JsonPropertyName("auto_type")]
    public required object AutoType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel_count")]
    public int? ChannelCount { get; init; }

    [JsonPropertyName("created_by")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string CreatedBy { get; init; }

    [JsonPropertyName("date_create")]
    public required int DateCreate { get; init; }

    [JsonPropertyName("date_delete")]
    public required int DateDelete { get; init; }

    [JsonPropertyName("date_update")]
    public required int DateUpdate { get; init; }

    [JsonPropertyName("deleted_by")]
    public required object DeletedBy { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("enterprise_subteam_id")]
    public required string EnterpriseSubteamId { get; init; }

    [JsonPropertyName("handle")]
    public required string Handle { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^S[A-Z0-9]{2,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("is_external")]
    public required bool IsExternal { get; init; }

    [JsonPropertyName("is_subteam")]
    public required bool IsSubteam { get; init; }

    [JsonPropertyName("is_usergroup")]
    public required bool IsUsergroup { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("prefs")]
    public required Prefs Prefs { get; init; }

    [JsonPropertyName("team_id")]
    [RegularExpression("^[T][A-Z0-9]{2,}$")]
    public required string TeamId { get; init; }

    [JsonPropertyName("updated_by")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string UpdatedBy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_count")]
    public int? UserCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("users")]
    public IReadOnlyList<string>? Users { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
