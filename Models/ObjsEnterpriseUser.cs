using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Slack.Core.Validation.Attributes;

namespace Slack.Models;

public record ObjsEnterpriseUser
{
    [JsonPropertyName("enterprise_id")]
    [RegularExpression("^[E][A-Z0-9]{8,}$")]
    public required string EnterpriseId { get; init; }

    [JsonPropertyName("enterprise_name")]
    public required string EnterpriseName { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^[WU][A-Z0-9]{8,}$")]
    public required string Id { get; init; }

    [JsonPropertyName("is_admin")]
    public required bool IsAdmin { get; init; }

    [JsonPropertyName("is_owner")]
    public required bool IsOwner { get; init; }

    [JsonPropertyName("teams")]
    [UniqueItems]
    public required IReadOnlyList<string> Teams { get; init; }
}
