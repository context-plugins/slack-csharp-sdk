using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsDeleteErrorEnum>))]
public sealed record AdminConversationsDeleteErrorEnum : StringEnum<AdminConversationsDeleteErrorEnum>
{
    private AdminConversationsDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsDeleteErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsDeleteErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsDeleteErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsDeleteErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsDeleteErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static readonly AdminConversationsDeleteErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsDeleteErrorEnum CouldNotDeleteChannel = new("could_not_delete_channel");

    public static readonly AdminConversationsDeleteErrorEnum MissingScope = new("missing_scope");

    public static AdminConversationsDeleteErrorEnum FromValue(string value) => FromValueCore(value);
}
