using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatScheduleMessageErrorEnum>))]
public sealed record ChatScheduleMessageErrorEnum : StringEnum<ChatScheduleMessageErrorEnum>
{
    private ChatScheduleMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatScheduleMessageErrorEnum InvalidTime = new("invalid_time");

    public static readonly ChatScheduleMessageErrorEnum TimeInPast = new("time_in_past");

    public static readonly ChatScheduleMessageErrorEnum TimeTooFar = new("time_too_far");

    public static readonly ChatScheduleMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatScheduleMessageErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ChatScheduleMessageErrorEnum IsArchived = new("is_archived");

    public static readonly ChatScheduleMessageErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatScheduleMessageErrorEnum NoText = new("no_text");

    public static readonly ChatScheduleMessageErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ChatScheduleMessageErrorEnum RestrictedActionReadOnlyChannel = new("restricted_action_read_only_channel");

    public static readonly ChatScheduleMessageErrorEnum RestrictedActionThreadOnlyChannel = new("restricted_action_thread_only_channel");

    public static readonly ChatScheduleMessageErrorEnum RestrictedActionNonThreadableChannel = new("restricted_action_non_threadable_channel");

    public static readonly ChatScheduleMessageErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatScheduleMessageErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatScheduleMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatScheduleMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatScheduleMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatScheduleMessageErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatScheduleMessageErrorEnum NoPermission = new("no_permission");

    public static readonly ChatScheduleMessageErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatScheduleMessageErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly ChatScheduleMessageErrorEnum MissingScope = new("missing_scope");

    public static readonly ChatScheduleMessageErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly ChatScheduleMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatScheduleMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatScheduleMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatScheduleMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatScheduleMessageErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatScheduleMessageErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatScheduleMessageErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatScheduleMessageErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatScheduleMessageErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatScheduleMessageErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatScheduleMessageErrorEnum FatalError = new("fatal_error");

    public static ChatScheduleMessageErrorEnum FromValue(string value) => FromValueCore(value);
}
