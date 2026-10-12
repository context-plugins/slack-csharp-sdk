using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsSetConversationPrefsErrorEnum>))]
public sealed record AdminConversationsSetConversationPrefsErrorEnum : OpenStringEnum<AdminConversationsSetConversationPrefsErrorEnum>
{
    private AdminConversationsSetConversationPrefsErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsSetConversationPrefsErrorEnum FeatureNotEnabled = new(
        "feature_not_enabled");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum MissingScope = new("missing_scope");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum CouldNotSetChannelPref = new(
        "could_not_set_channel_pref");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum DefaultOrgWideChannel = new(
        "default_org_wide_channel");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onNotAnAdmin,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onRestrictedAction,
        Func<TResult> onMissingScope,
        Func<TResult> onCouldNotSetChannelPref,
        Func<TResult> onDefaultOrgWideChannel,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == NotAnAdmin => onNotAnAdmin(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == CouldNotSetChannelPref => onCouldNotSetChannelPref(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onNotAnAdmin,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onRestrictedAction,
        Action onMissingScope,
        Action onCouldNotSetChannelPref,
        Action onDefaultOrgWideChannel,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == NotAnAdmin) onNotAnAdmin();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == MissingScope) onMissingScope();
        else if (this == CouldNotSetChannelPref) onCouldNotSetChannelPref();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else otherwise(Value);
    }
}
