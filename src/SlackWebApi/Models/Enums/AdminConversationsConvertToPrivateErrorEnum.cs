using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsConvertToPrivateErrorEnum>))]
public sealed record AdminConversationsConvertToPrivateErrorEnum : OpenStringEnum<AdminConversationsConvertToPrivateErrorEnum>
{
    private AdminConversationsConvertToPrivateErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsConvertToPrivateErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsConvertToPrivateErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsConvertToPrivateErrorEnum NameTaken = new("name_taken");

    public static readonly AdminConversationsConvertToPrivateErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsConvertToPrivateErrorEnum ChannelTypeNotSupported = new(
        "channel_type_not_supported");

    public static readonly AdminConversationsConvertToPrivateErrorEnum DefaultOrgWideChannel = new(
        "default_org_wide_channel");

    public static readonly AdminConversationsConvertToPrivateErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly AdminConversationsConvertToPrivateErrorEnum CouldNotConvertChannel = new(
        "could_not_convert_channel");

    public static readonly AdminConversationsConvertToPrivateErrorEnum ExternalChannelMigrating = new(
        "external_channel_migrating");

    public TResult Match<TResult>(Func<TResult> onFeatureNotEnabled,
        Func<TResult> onRestrictedAction,
        Func<TResult> onNameTaken,
        Func<TResult> onChannelNotFound,
        Func<TResult> onChannelTypeNotSupported,
        Func<TResult> onDefaultOrgWideChannel,
        Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onCouldNotConvertChannel,
        Func<TResult> onExternalChannelMigrating,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureNotEnabled => onFeatureNotEnabled(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == NameTaken => onNameTaken(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == ChannelTypeNotSupported => onChannelTypeNotSupported(),
            _ when this == DefaultOrgWideChannel => onDefaultOrgWideChannel(),
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == CouldNotConvertChannel => onCouldNotConvertChannel(),
            _ when this == ExternalChannelMigrating => onExternalChannelMigrating(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureNotEnabled,
        Action onRestrictedAction,
        Action onNameTaken,
        Action onChannelNotFound,
        Action onChannelTypeNotSupported,
        Action onDefaultOrgWideChannel,
        Action onMethodNotSupportedForChannelType,
        Action onCouldNotConvertChannel,
        Action onExternalChannelMigrating,
        Action<string> otherwise)
    {
        if (this == FeatureNotEnabled) onFeatureNotEnabled();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == NameTaken) onNameTaken();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == ChannelTypeNotSupported) onChannelTypeNotSupported();
        else if (this == DefaultOrgWideChannel) onDefaultOrgWideChannel();
        else if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == CouldNotConvertChannel) onCouldNotConvertChannel();
        else if (this == ExternalChannelMigrating) onExternalChannelMigrating();
        else otherwise(Value);
    }
}
