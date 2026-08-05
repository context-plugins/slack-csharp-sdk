using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsLeaveErrorEnum>))]
public sealed record ConversationsLeaveErrorEnum : StringEnum<ConversationsLeaveErrorEnum>
{
    private ConversationsLeaveErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsLeaveErrorEnum MethodNotSupportedForChannelType = new("method_not_supported_for_channel_type");

    public static readonly ConversationsLeaveErrorEnum LastMember = new("last_member");

    public static readonly ConversationsLeaveErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsLeaveErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsLeaveErrorEnum IsArchived = new("is_archived");

    public static readonly ConversationsLeaveErrorEnum CantLeaveGeneral = new("cant_leave_general");

    public static readonly ConversationsLeaveErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsLeaveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsLeaveErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsLeaveErrorEnum UserIsBot = new("user_is_bot");

    public static readonly ConversationsLeaveErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly ConversationsLeaveErrorEnum UserIsUltraRestricted = new("user_is_ultra_restricted");

    public static readonly ConversationsLeaveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsLeaveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsLeaveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsLeaveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsLeaveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsLeaveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsLeaveErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsLeaveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsLeaveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsLeaveErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsLeaveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ConversationsLeaveErrorEnum MissingCharset = new("missing_charset");

    public static readonly ConversationsLeaveErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static ConversationsLeaveErrorEnum FromValue(string value) => FromValueCore(value);
}
