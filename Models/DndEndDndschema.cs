using System.Text.Json.Serialization;

namespace SlackWebApi.Models;

/// <summary>
/// Schema for successful response from dnd.endDnd method
/// </summary>
public record DndEndDndschema
{
    [JsonPropertyName("ok")]
    public required bool Ok { get; init; }
}
