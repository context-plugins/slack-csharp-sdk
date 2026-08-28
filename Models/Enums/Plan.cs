using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Plan>))]
public sealed record Plan : StringEnum<Plan>
{
    private Plan(string value) : base(value)
    {
    }

    public static readonly Plan Std = new("std");

    public static readonly Plan Plus = new("plus");

    public static readonly Plan Compliance = new("compliance");

    public static readonly Plan Enterprise = new("enterprise");

    public static Plan FromValue(string value) => FromValueCore(value);
}
