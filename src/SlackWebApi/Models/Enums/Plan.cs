using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Plan>))]
public sealed record Plan : OpenStringEnum<Plan>
{
    private Plan(string value) : base(value)
    {
    }

    public static readonly Plan Std = new("std");

    public static readonly Plan Plus = new("plus");

    public static readonly Plan Compliance = new("compliance");

    public static readonly Plan Enterprise = new("enterprise");

    public TResult Match<TResult>(Func<TResult> onStd,
        Func<TResult> onPlus,
        Func<TResult> onCompliance,
        Func<TResult> onEnterprise,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Std => onStd(),
            _ when this == Plus => onPlus(),
            _ when this == Compliance => onCompliance(),
            _ when this == Enterprise => onEnterprise(),
            _ => otherwise(Value)
        };

    public void Match(Action onStd, Action onPlus, Action onCompliance, Action onEnterprise, Action<string> otherwise)
    {
        if (this == Std) onStd();
        else if (this == Plus) onPlus();
        else if (this == Compliance) onCompliance();
        else if (this == Enterprise) onEnterprise();
        else otherwise(Value);
    }
}
