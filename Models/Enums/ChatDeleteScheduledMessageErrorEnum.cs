using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatDeleteScheduledMessageErrorEnum>))]
public sealed record ChatDeleteScheduledMessageErrorEnum : StringEnum<ChatDeleteScheduledMessageErrorEnum>
{
    private ChatDeleteScheduledMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidScheduledMessageId = new("invalid_scheduled_message_id");

    public static readonly ChatDeleteScheduledMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatDeleteScheduledMessageErrorEnum BadToken = new("bad_token");

    public static readonly ChatDeleteScheduledMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatDeleteScheduledMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatDeleteScheduledMessageErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatDeleteScheduledMessageErrorEnum NoPermission = new("no_permission");

    public static readonly ChatDeleteScheduledMessageErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatDeleteScheduledMessageErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly ChatDeleteScheduledMessageErrorEnum MissingScope = new("missing_scope");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatDeleteScheduledMessageErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatDeleteScheduledMessageErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatDeleteScheduledMessageErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatDeleteScheduledMessageErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatDeleteScheduledMessageErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatDeleteScheduledMessageErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatDeleteScheduledMessageErrorEnum FatalError = new("fatal_error");

    public static ChatDeleteScheduledMessageErrorEnum FromValue(string value) => FromValueCore(value);
}
