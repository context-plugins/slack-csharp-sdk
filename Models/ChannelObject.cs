using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Models;
using SlackWebApi.Core.Validation.Attributes;

namespace SlackWebApi.Models;

public record ChannelObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_user")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public string? AcceptedUser { get; init; }

    [JsonPropertyName("created")]
    public required int Created { get; init; }

    [JsonPropertyName("creator")]
    [RegularExpression("^[UW][A-Z0-9]{2,}$")]
    public required string Creator { get; init; }

    [JsonPropertyName("id")]
    [RegularExpression("^[C][A-Z0-9]{2,}$")]
    public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_archived")]
    public bool? IsArchived { get; init; }

    [JsonPropertyName("is_channel")]
    public required bool IsChannel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_frozen")]
    public bool? IsFrozen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_general")]
    public bool? IsGeneral { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_member")]
    public bool? IsMember { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_moved")]
    public int? IsMoved { get; init; }

    [JsonPropertyName("is_mpim")]
    public required bool IsMpim { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_non_threadable")]
    public bool? IsNonThreadable { get; init; }

    [JsonPropertyName("is_org_shared")]
    public required bool IsOrgShared { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_pending_ext_shared")]
    public bool? IsPendingExtShared { get; init; }

    [JsonPropertyName("is_private")]
    public required bool IsPrivate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_read_only")]
    public bool? IsReadOnly { get; init; }

    [JsonPropertyName("is_shared")]
    public required bool IsShared { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_thread_only")]
    public bool? IsThreadOnly { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_read")]
    [RegularExpression("^\\d{10}\\.\\d{6}$")]
    public string? LastRead { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest")]
    public object? Latest { get; init; }

    [JsonPropertyName("members")]
    [MinLength(0)]
    [UniqueItems]
    public required IReadOnlyList<string> Members { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("name_normalized")]
    public required string NameNormalized { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_members")]
    public int? NumMembers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pending_shared")]
    [MinLength(0)]
    [UniqueItems]
    public IReadOnlyList<string>? PendingShared { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previous_names")]
    [MinLength(0)]
    [UniqueItems]
    public IReadOnlyList<string>? PreviousNames { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public double? Priority { get; init; }

    [JsonPropertyName("purpose")]
    public required Purpose Purpose { get; init; }

    [JsonPropertyName("topic")]
    public required Topic Topic { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unlinked")]
    public int? Unlinked { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unread_count")]
    public int? UnreadCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unread_count_display")]
    public int? UnreadCountDisplay { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
