using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Ok1>))]
public sealed record Ok1 : StringEnum<Ok1>
{
    private Ok1(string value) : base(value)
    {
    }

    public static readonly Ok1 True = new("True");

    public static Ok1 FromValue(string value) => FromValueCore(value);
}
