using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ContentType>))]
public sealed record ContentType : OpenStringEnum<ContentType>
{
    private ContentType(string value) : base(value)
    {
    }

    public static readonly ContentType ApplicationXWwwFormUrlencoded = new("application/x-www-form-urlencoded");

    public TResult Match<TResult>(Func<TResult> onApplicationXWwwFormUrlencoded, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ApplicationXWwwFormUrlencoded => onApplicationXWwwFormUrlencoded(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplicationXWwwFormUrlencoded, Action<string> otherwise)
    {
        if (this == ApplicationXWwwFormUrlencoded) onApplicationXWwwFormUrlencoded();
        else otherwise(Value);
    }
}
