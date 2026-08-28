using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsKickErrorEnum>))]
public sealed record ConversationsKickErrorEnum : StringEnum<ConversationsKickErrorEnum>
{
    private ConversationsKickErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsKickErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsKickErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsKickErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsKickErrorEnum UserNotFound = new("user_not_found");

    public static readonly ConversationsKickErrorEnum CantKickSelf = new("cant_kick_self");

    public static readonly ConversationsKickErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsKickErrorEnum CantKickFromGeneral = new("cant_kick_from_general");

    public static readonly ConversationsKickErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ConversationsKickErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsKickErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsKickErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsKickErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsKickErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsKickErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsKickErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsKickErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsKickErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsKickErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsKickErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsKickErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsKickErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsKickErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsKickErrorEnum UpgradeRequired = new("upgrade_required");

    public static ConversationsKickErrorEnum FromValue(string value) => FromValueCore(value);
}
