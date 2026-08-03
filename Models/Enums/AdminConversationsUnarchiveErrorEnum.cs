using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsUnarchiveErrorEnum>))]
public sealed record AdminConversationsUnarchiveErrorEnum : StringEnum<AdminConversationsUnarchiveErrorEnum>
{
    private AdminConversationsUnarchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsUnarchiveErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsUnarchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsUnarchiveErrorEnum ChannelNotArchived = new("channel_not_archived");

    public static readonly AdminConversationsUnarchiveErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsUnarchiveErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsUnarchiveErrorEnum CouldNotUnarchiveChannel = new("could_not_unarchive_channel");

    public static readonly AdminConversationsUnarchiveErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsUnarchiveErrorEnum MissingScope = new("missing_scope");

    public static AdminConversationsUnarchiveErrorEnum FromValue(string value) => FromValueCore(value);
}
