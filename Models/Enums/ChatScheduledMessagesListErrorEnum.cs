using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatScheduledMessagesListErrorEnum>))]
public sealed record ChatScheduledMessagesListErrorEnum : StringEnum<ChatScheduledMessagesListErrorEnum>
{
    private ChatScheduledMessagesListErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatScheduledMessagesListErrorEnum InvalidChannel = new("invalid_channel");

    public static readonly ChatScheduledMessagesListErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatScheduledMessagesListErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatScheduledMessagesListErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatScheduledMessagesListErrorEnum NoPermission = new("no_permission");

    public static readonly ChatScheduledMessagesListErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatScheduledMessagesListErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly ChatScheduledMessagesListErrorEnum MissingScope = new("missing_scope");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatScheduledMessagesListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatScheduledMessagesListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatScheduledMessagesListErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatScheduledMessagesListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatScheduledMessagesListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatScheduledMessagesListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatScheduledMessagesListErrorEnum FatalError = new("fatal_error");

    public static ChatScheduledMessagesListErrorEnum FromValue(string value) => FromValueCore(value);
}
