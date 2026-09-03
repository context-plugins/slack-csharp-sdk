using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Text = new("text");

    public static readonly TypeEnum Date = new("date");

    public static readonly TypeEnum Link = new("link");

    public static readonly TypeEnum Mailto = new("mailto");

    public static readonly TypeEnum OptionsList = new("options_list");

    public static readonly TypeEnum User = new("user");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
