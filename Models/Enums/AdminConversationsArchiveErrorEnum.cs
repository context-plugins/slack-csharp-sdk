using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsArchiveErrorEnum>))]
public sealed record AdminConversationsArchiveErrorEnum : StringEnum<AdminConversationsArchiveErrorEnum>
{
    private AdminConversationsArchiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsArchiveErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsArchiveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsArchiveErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsArchiveErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsArchiveErrorEnum AlreadyArchived = new("already_archived");

    public static readonly AdminConversationsArchiveErrorEnum CantArchiveGeneral = new("cant_archive_general");

    public static readonly AdminConversationsArchiveErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsArchiveErrorEnum CouldNotArchiveChannel = new("could_not_archive_channel");

    public static AdminConversationsArchiveErrorEnum FromValue(string value) => FromValueCore(value);
}
