using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsDeleteErrorEnum>))]
public sealed record AdminConversationsDeleteErrorEnum : OpenStringEnum<AdminConversationsDeleteErrorEnum>
{
    private AdminConversationsDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsDeleteErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsDeleteErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsDeleteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsDeleteErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsDeleteErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsDeleteErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsDeleteErrorEnum CouldNotDeleteChannel = new("could_not_delete_channel");

    public static readonly AdminConversationsDeleteErrorEnum MissingScope = new("missing_scope");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onNotAnAdmin,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onDefaultOrgWideChannel,
        Func<TResult> onRestrictedAction,
        Func<TResult> onCouldNotDeleteChannel,
        Func<TResult> onMissingScope,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == NotAnAdmin => onNotAnAdmin(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == CouldNotDeleteChannel => onCouldNotDeleteChannel(),
            _ when this == MissingScope => onMissingScope(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onNotAnAdmin,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onDefaultOrgWideChannel,
        Action onRestrictedAction,
        Action onCouldNotDeleteChannel,
        Action onMissingScope,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == NotAnAdmin) onNotAnAdmin();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == CouldNotDeleteChannel) onCouldNotDeleteChannel();
        else if (this == MissingScope) onMissingScope();
        else otherwise(Value);
    }
}
