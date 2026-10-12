using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsGetConversationPrefsErrorEnum>))]
public sealed record AdminConversationsGetConversationPrefsErrorEnum : OpenStringEnum<AdminConversationsGetConversationPrefsErrorEnum>
{
    private AdminConversationsGetConversationPrefsErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsGetConversationPrefsErrorEnum FeatureNotEnabled = new(
        "feature_not_enabled");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum NotAnEnterprise = new("not_an_enterprise");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum MissingScope = new("missing_scope");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum CouldNotGetConversationPrefs = new(
        "could_not_get_conversation_prefs");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onNotAnAdmin,
        Func<TResult> onNotAnEnterprise,
        Func<TResult> onRestrictedAction,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onCouldNotGetConversationPrefs,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == NotAnAdmin => onNotAnAdmin(),
            _ when this == NotAnEnterprise => onNotAnEnterprise(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == CouldNotGetConversationPrefs => onCouldNotGetConversationPrefs(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onNotAnAdmin,
        Action onNotAnEnterprise,
        Action onRestrictedAction,
        Action onMissingScope,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onCouldNotGetConversationPrefs,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == NotAnAdmin) onNotAnAdmin();
        else if (this == NotAnEnterprise) onNotAnEnterprise();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == CouldNotGetConversationPrefs) onCouldNotGetConversationPrefs();
        else otherwise(Value);
    }
}
