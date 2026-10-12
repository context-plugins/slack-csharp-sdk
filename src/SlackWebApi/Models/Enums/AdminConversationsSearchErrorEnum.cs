using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsSearchErrorEnum>))]
public sealed record AdminConversationsSearchErrorEnum : OpenStringEnum<AdminConversationsSearchErrorEnum>
{
    private AdminConversationsSearchErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsSearchErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsSearchErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsSearchErrorEnum NotAnEnterprise = new("not_an_enterprise");

    public static readonly AdminConversationsSearchErrorEnum TeamNotFound = new("team_not_found");

    public static readonly AdminConversationsSearchErrorEnum NotAllowed = new("not_allowed");

    public static readonly AdminConversationsSearchErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AdminConversationsSearchErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly AdminConversationsSearchErrorEnum InvalidSearchChannelType = new(
        "invalid_search_channel_type");

    public static readonly AdminConversationsSearchErrorEnum InvalidSort = new("invalid_sort");

    public static readonly AdminConversationsSearchErrorEnum InvalidSortDir = new("invalid_sort_dir");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onNotAnAdmin,
        Func<TResult> onNotAnEnterprise,
        Func<TResult> onTeamNotFound,
        Func<TResult> onNotAllowed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onInvalidCursor,
        Func<TResult> onInvalidSearchChannelType,
        Func<TResult> onInvalidSort,
        Func<TResult> onInvalidSortDir,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == NotAnAdmin => onNotAnAdmin(),
            _ when this == NotAnEnterprise => onNotAnEnterprise(),
            _ when this == TeamNotFound => onTeamNotFound(),
            _ when this == NotAllowed => onNotAllowed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == InvalidCursor => onInvalidCursor(),
            _ when this == InvalidSearchChannelType => onInvalidSearchChannelType(),
            _ when this == InvalidSort => onInvalidSort(),
            _ when this == InvalidSortDir => onInvalidSortDir(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onNotAnAdmin,
        Action onNotAnEnterprise,
        Action onTeamNotFound,
        Action onNotAllowed,
        Action onInvalidAuth,
        Action onInvalidCursor,
        Action onInvalidSearchChannelType,
        Action onInvalidSort,
        Action onInvalidSortDir,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == NotAnAdmin) onNotAnAdmin();
        else if (this == NotAnEnterprise) onNotAnEnterprise();
        else if (this == TeamNotFound) onTeamNotFound();
        else if (this == NotAllowed) onNotAllowed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == InvalidCursor) onInvalidCursor();
        else if (this == InvalidSearchChannelType) onInvalidSearchChannelType();
        else if (this == InvalidSort) onInvalidSort();
        else if (this == InvalidSortDir) onInvalidSortDir();
        else otherwise(Value);
    }
}
