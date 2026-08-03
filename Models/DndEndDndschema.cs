using System.Text.Json.Serialization;
using SlackWebApi.Models.Enums;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from dnd.endDnd method
/// </summary>
public record DndEndDndschema
{
    [JsonPropertyName("ok")]
    public required Ok1 Ok { get; init; }
}
