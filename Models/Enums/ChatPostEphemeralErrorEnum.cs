using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatPostEphemeralErrorEnum>))]
public sealed record ChatPostEphemeralErrorEnum : StringEnum<ChatPostEphemeralErrorEnum>
{
    private ChatPostEphemeralErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatPostEphemeralErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatPostEphemeralErrorEnum IsArchived = new("is_archived");

    public static readonly ChatPostEphemeralErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatPostEphemeralErrorEnum NoText = new("no_text");

    public static readonly ChatPostEphemeralErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ChatPostEphemeralErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatPostEphemeralErrorEnum UserNotInChannel = new("user_not_in_channel");

    public static readonly ChatPostEphemeralErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatPostEphemeralErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatPostEphemeralErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatPostEphemeralErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatPostEphemeralErrorEnum NoPermission = new("no_permission");

    public static readonly ChatPostEphemeralErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatPostEphemeralErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatPostEphemeralErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatPostEphemeralErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatPostEphemeralErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatPostEphemeralErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatPostEphemeralErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatPostEphemeralErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatPostEphemeralErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatPostEphemeralErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatPostEphemeralErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatPostEphemeralErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatPostEphemeralErrorEnum FatalError = new("fatal_error");

    public static ChatPostEphemeralErrorEnum FromValue(string value) => FromValueCore(value);
}
