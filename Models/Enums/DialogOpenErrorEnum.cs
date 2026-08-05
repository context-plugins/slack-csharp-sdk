using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DialogOpenErrorEnum>))]
public sealed record DialogOpenErrorEnum : StringEnum<DialogOpenErrorEnum>
{
    private DialogOpenErrorEnum(string value) : base(value)
    {
    }

    public static readonly DialogOpenErrorEnum ValidationErrors = new("validation_errors");

    public static readonly DialogOpenErrorEnum MissingTrigger = new("missing_trigger");

    public static readonly DialogOpenErrorEnum MissingDialog = new("missing_dialog");

    public static readonly DialogOpenErrorEnum TriggerExchanged = new("trigger_exchanged");

    public static readonly DialogOpenErrorEnum TriggerExpired = new("trigger_expired");

    public static readonly DialogOpenErrorEnum InvalidTrigger = new("invalid_trigger");

    public static readonly DialogOpenErrorEnum AppMissingActionUrl = new("app_missing_action_url");

    public static readonly DialogOpenErrorEnum CannotCreateDialog = new("cannot_create_dialog");

    public static readonly DialogOpenErrorEnum FailedSendingDialog = new("failed_sending_dialog");

    public static readonly DialogOpenErrorEnum NotAuthed = new("not_authed");

    public static readonly DialogOpenErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DialogOpenErrorEnum AccountInactive = new("account_inactive");

    public static readonly DialogOpenErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DialogOpenErrorEnum NoPermission = new("no_permission");

    public static readonly DialogOpenErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DialogOpenErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DialogOpenErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DialogOpenErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DialogOpenErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DialogOpenErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DialogOpenErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DialogOpenErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DialogOpenErrorEnum InvalidJson = new("invalid_json");

    public static readonly DialogOpenErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DialogOpenErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DialogOpenErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DialogOpenErrorEnum FatalError = new("fatal_error");

    public static DialogOpenErrorEnum FromValue(string value) => FromValueCore(value);
}
