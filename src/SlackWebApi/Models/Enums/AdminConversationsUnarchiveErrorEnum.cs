using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsUnarchiveErrorEnum>))]
public sealed record AdminConversationsUnarchiveErrorEnum : OpenStringEnum<AdminConversationsUnarchiveErrorEnum>
{
    private AdminConversationsUnarchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsUnarchiveErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsUnarchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsUnarchiveErrorEnum ChannelNotArchived = new("channel_not_archived");

    public static readonly AdminConversationsUnarchiveErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsUnarchiveErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsUnarchiveErrorEnum CouldNotUnarchiveChannel = new(
        "could_not_unarchive_channel");

    public static readonly AdminConversationsUnarchiveErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsUnarchiveErrorEnum MissingScope = new("missing_scope");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelNotArchived,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onRestrictedAction,
        Func<TResult> onCouldNotUnarchiveChannel,
        Func<TResult> onDefaultOrgWideChannel,
        Func<TResult> onMissingScope,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelNotArchived => onChannelNotArchived(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == CouldNotUnarchiveChannel => onCouldNotUnarchiveChannel(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ when this == MissingScope => onMissingScope(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onChannelNotFound,
        Action onChannelNotArchived,
        Action onChannelTypeNotSupported,
        Action onRestrictedAction,
        Action onCouldNotUnarchiveChannel,
        Action onDefaultOrgWideChannel,
        Action onMissingScope,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelNotArchived) onChannelNotArchived();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == CouldNotUnarchiveChannel) onCouldNotUnarchiveChannel();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else if (this == MissingScope) onMissingScope();
        else otherwise(Value);
    }
}
