using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsRenameErrorEnum>))]
public sealed record AdminConversationsRenameErrorEnum : StringEnum<AdminConversationsRenameErrorEnum>
{
    private AdminConversationsRenameErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsRenameErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsRenameErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsRenameErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsRenameErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsRenameErrorEnum CouldNotRenameChannel = new("could_not_rename_channel");

    public static readonly AdminConversationsRenameErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsRenameErrorEnum NameTaken = new("name_taken");

    public static AdminConversationsRenameErrorEnum FromValue(string value) => FromValueCore(value);
}
