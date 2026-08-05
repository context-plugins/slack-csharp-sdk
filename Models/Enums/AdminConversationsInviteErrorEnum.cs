using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsInviteErrorEnum>))]
public sealed record AdminConversationsInviteErrorEnum : StringEnum<AdminConversationsInviteErrorEnum>
{
    private AdminConversationsInviteErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsInviteErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsInviteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsInviteErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsInviteErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsInviteErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsInviteErrorEnum UserMustBeAdmin = new("user_must_be_admin");

    public static readonly AdminConversationsInviteErrorEnum FailedForSomeUsers = new("failed_for_some_users");

    public static AdminConversationsInviteErrorEnum FromValue(string value) => FromValueCore(value);
}
