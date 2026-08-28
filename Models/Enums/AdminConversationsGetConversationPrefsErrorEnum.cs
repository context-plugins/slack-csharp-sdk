using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdminConversationsGetConversationPrefsErrorEnum>))]
public sealed record AdminConversationsGetConversationPrefsErrorEnum : StringEnum<AdminConversationsGetConversationPrefsErrorEnum>
{
    private AdminConversationsGetConversationPrefsErrorEnum(string value) : base(value)
    {
    }

    public static readonly AdminConversationsGetConversationPrefsErrorEnum FeatureNotEnabled = new("feature_not_enabled");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum NotAnAdmin = new("not_an_admin");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum NotAnEnterprise = new("not_an_enterprise");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum RestrictedAction = new("restricted_action");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum MissingScope = new("missing_scope");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum ChannelTypeNotSupported = new("channel_type_not_supported");

    public static readonly AdminConversationsGetConversationPrefsErrorEnum CouldNotGetConversationPrefs = new("could_not_get_conversation_prefs");

    public static AdminConversationsGetConversationPrefsErrorEnum FromValue(string value) =>
        FromValueCore(value);
}
