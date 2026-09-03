using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsConvertToPrivateErrorEnum>))]
public sealed record AdminConversationsConvertToPrivateErrorEnum : StringEnum<AdminConversationsConvertToPrivateErrorEnum>
{
    private AdminConversationsConvertToPrivateErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsConvertToPrivateErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsConvertToPrivateErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsConvertToPrivateErrorEnum NameTaken = new("name_taken");

    public static readonly AdminConversationsConvertToPrivateErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsConvertToPrivateErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsConvertToPrivateErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsConvertToPrivateErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly AdminConversationsConvertToPrivateErrorEnum CouldNotConvertChannel = new("could_not_convert_channel");

    public static readonly AdminConversationsConvertToPrivateErrorEnum ExternalChannelMigrating = new("external_channel_migrating");

    public static AdminConversationsConvertToPrivateErrorEnum FromValue(string value) => FromValueCore(value);
}
