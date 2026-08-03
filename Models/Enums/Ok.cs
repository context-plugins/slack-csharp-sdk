using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Ok>))]
public sealed record Ok : StringEnum<Ok>
{
    private Ok(string value) : base(value)
    {
    }

    public static readonly Ok False = new("False");

    public static Ok FromValue(string value) => FromValueCore(value);
}
