using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsSetConversationPrefsErrorEnum>))]
public sealed record AdminConversationsSetConversationPrefsErrorEnum : StringEnum<AdminConversationsSetConversationPrefsErrorEnum>
{
    private AdminConversationsSetConversationPrefsErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsSetConversationPrefsErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum MissingScope = new("missing_scope");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum CouldNotSetChannelPref = new("could_not_set_channel_pref");

    public static readonly AdminConversationsSetConversationPrefsErrorEnum DefaultOrgWideChannel = new("default_org_wide_channel");

    public static AdminConversationsSetConversationPrefsErrorEnum FromValue(string value) =>
        FromValueCore(value);
}
