using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
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

    public TResult Match<TResult>(Func<TResult> onText,
        Func<TResult> onDate,
        Func<TResult> onLink,
        Func<TResult> onMailto,
        Func<TResult> onOptionsList,
        Func<TResult> onUser,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Text => onText(),
            _ when this == Date => onDate(),
            _ when this == Link => onLink(),
            _ when this == Mailto => onMailto(),
            _ when this == OptionsList => onOptionsList(),
            _ when this == User => onUser(),
            _ => otherwise(Value)
        };

    public void Match(Action onText,
        Action onDate,
        Action onLink,
        Action onMailto,
        Action onOptionsList,
        Action onUser,
        Action<string> otherwise)
    {
        if (this == Text) onText();
        else if (this == Date) onDate();
        else if (this == Link) onLink();
        else if (this == Mailto) onMailto();
        else if (this == OptionsList) onOptionsList();
        else if (this == User) onUser();
        else otherwise(Value);
    }
}
