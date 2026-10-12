using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsArchiveErrorEnum>))]
public sealed record AdminConversationsArchiveErrorEnum : OpenStringEnum<AdminConversationsArchiveErrorEnum>
{
    private AdminConversationsArchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsArchiveErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsArchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsArchiveErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsArchiveErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsArchiveErrorEnum AlreadyArchived = new("already_archived");

    public static readonly AdminConversationsArchiveErrorEnum CantArchiveGeneral = new("cant_archive_general");

    public static readonly AdminConversationsArchiveErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsArchiveErrorEnum CouldNotArchiveChannel = new("could_not_archive_channel");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onDefaultOrgWideChannel,
        Func<TResult> onAlreadyArchived,
        Func<TResult> onCantArchiveGeneral,
        Func<TResult> onRestrictedAction,
        Func<TResult> onCouldNotArchiveChannel,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ when this == AlreadyArchived => onAlreadyArchived(),
            _ when this == CantArchiveGeneral => onCantArchiveGeneral(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == CouldNotArchiveChannel => onCouldNotArchiveChannel(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onDefaultOrgWideChannel,
        Action onAlreadyArchived,
        Action onCantArchiveGeneral,
        Action onRestrictedAction,
        Action onCouldNotArchiveChannel,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else if (this == AlreadyArchived) onAlreadyArchived();
        else if (this == CantArchiveGeneral) onCantArchiveGeneral();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == CouldNotArchiveChannel) onCouldNotArchiveChannel();
        else otherwise(Value);
    }
}
