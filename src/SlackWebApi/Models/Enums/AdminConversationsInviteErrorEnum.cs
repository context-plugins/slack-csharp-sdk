using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsInviteErrorEnum>))]
public sealed record AdminConversationsInviteErrorEnum : OpenStringEnum<AdminConversationsInviteErrorEnum>
{
    private AdminConversationsInviteErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsInviteErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsInviteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsInviteErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsInviteErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsInviteErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsInviteErrorEnum UserMustBeAdmin = new("user_must_be_admin");

    public static readonly AdminConversationsInviteErrorEnum FailedForSomeUsers = new("failed_for_some_users");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onDefaultOrgWideChannel,
        Func<TResult> onRestrictedAction,
        Func<TResult> onUserMustBeAdmin,
        Func<TResult> onFailedForSomeUsers,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == UserMustBeAdmin => onUserMustBeAdmin(),
            _ when this == FailedForSomeUsers => onFailedForSomeUsers(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onDefaultOrgWideChannel,
        Action onRestrictedAction,
        Action onUserMustBeAdmin,
        Action onFailedForSomeUsers,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == UserMustBeAdmin) onUserMustBeAdmin();
        else if (this == FailedForSomeUsers) onFailedForSomeUsers();
        else otherwise(Value);
    }
}
