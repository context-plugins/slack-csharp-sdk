using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatMeMessageErrorEnum>))]
public sealed record ChatMeMessageErrorEnum : StringEnum<ChatMeMessageErrorEnum>
{
    private ChatMeMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatMeMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatMeMessageErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ChatMeMessageErrorEnum IsArchived = new("is_archived");

    public static readonly ChatMeMessageErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatMeMessageErrorEnum NoText = new("no_text");

    public static readonly ChatMeMessageErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatMeMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatMeMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatMeMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatMeMessageErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatMeMessageErrorEnum NoPermission = new("no_permission");

    public static readonly ChatMeMessageErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatMeMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatMeMessageErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatMeMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatMeMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatMeMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatMeMessageErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatMeMessageErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatMeMessageErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatMeMessageErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatMeMessageErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatMeMessageErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatMeMessageErrorEnum FatalError = new("fatal_error");

    public static ChatMeMessageErrorEnum FromValue(string value) => FromValueCore(value);
}
