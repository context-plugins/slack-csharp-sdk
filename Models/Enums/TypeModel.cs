using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel Text = new("text");

    public static readonly TypeModel Date = new("date");

    public static readonly TypeModel Link = new("link");

    public static readonly TypeModel Mailto = new("mailto");

    public static readonly TypeModel OptionsList = new("options_list");

    public static readonly TypeModel User = new("user");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
