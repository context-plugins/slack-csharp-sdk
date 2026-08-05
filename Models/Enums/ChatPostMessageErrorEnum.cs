using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatPostMessageErrorEnum>))]
public sealed record ChatPostMessageErrorEnum : StringEnum<ChatPostMessageErrorEnum>
{
    private ChatPostMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatPostMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatPostMessageErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ChatPostMessageErrorEnum IsArchived = new("is_archived");

    public static readonly ChatPostMessageErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatPostMessageErrorEnum NoText = new("no_text");

    public static readonly ChatPostMessageErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatPostMessageErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatPostMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatPostMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatPostMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatPostMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatPostMessageErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatPostMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatPostMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatPostMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatPostMessageErrorEnum MissingPostType = new("missing_post_type");

    public static ChatPostMessageErrorEnum FromValue(string value) => FromValueCore(value);
}
