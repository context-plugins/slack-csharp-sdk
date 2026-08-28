using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ContentType>))]
public sealed record ContentType : StringEnum<ContentType>
{
    private ContentType(string value) : base(value)
    {
    }

    public static readonly ContentType ApplicationXWwwFormUrlencoded = new("application/x-www-form-urlencoded");

    public static ContentType FromValue(string value) => FromValueCore(value);
}
