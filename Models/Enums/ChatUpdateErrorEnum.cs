using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatUpdateErrorEnum>))]
public sealed record ChatUpdateErrorEnum : StringEnum<ChatUpdateErrorEnum>
{
    private ChatUpdateErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatUpdateErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ChatUpdateErrorEnum CantUpdateMessage = new("cant_update_message");

    public static readonly ChatUpdateErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatUpdateErrorEnum EditWindowClosed = new("edit_window_closed");

    public static readonly ChatUpdateErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatUpdateErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatUpdateErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatUpdateErrorEnum NoText = new("no_text");

    public static readonly ChatUpdateErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatUpdateErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatUpdateErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatUpdateErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatUpdateErrorEnum NoPermission = new("no_permission");

    public static readonly ChatUpdateErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatUpdateErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatUpdateErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatUpdateErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatUpdateErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatUpdateErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatUpdateErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatUpdateErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatUpdateErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatUpdateErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatUpdateErrorEnum FatalError = new("fatal_error");

    public static readonly ChatUpdateErrorEnum IsInactive = new("is_inactive");

    public static ChatUpdateErrorEnum FromValue(string value) => FromValueCore(value);
}
