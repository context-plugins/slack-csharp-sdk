using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsRenameErrorEnum>))]
public sealed record AdminConversationsRenameErrorEnum : OpenStringEnum<AdminConversationsRenameErrorEnum>
{
    private AdminConversationsRenameErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsRenameErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsRenameErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsRenameErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsRenameErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsRenameErrorEnum CouldNotRenameChannel = new("could_not_rename_channel");

    public static readonly AdminConversationsRenameErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsRenameErrorEnum NameTaken = new("name_taken");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onRestrictedAction,
        Func<TResult> onCouldNotRenameChannel,
        Func<TResult> onDefaultOrgWideChannel,
        Func<TResult> onNameTaken,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == CouldNotRenameChannel => onCouldNotRenameChannel(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ when this == NameTaken => onNameTaken(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onRestrictedAction,
        Action onCouldNotRenameChannel,
        Action onDefaultOrgWideChannel,
        Action onNameTaken,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == CouldNotRenameChannel) onCouldNotRenameChannel();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else if (this == NameTaken) onNameTaken();
        else otherwise(Value);
    }
}
