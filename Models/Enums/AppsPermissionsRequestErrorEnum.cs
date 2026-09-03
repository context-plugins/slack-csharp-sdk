using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AppsPermissionsRequestErrorEnum>))]
public sealed record AppsPermissionsRequestErrorEnum : StringEnum<AppsPermissionsRequestErrorEnum>
{
    private AppsPermissionsRequestErrorEnum(string value) : base(value)
    {
    }

    public static readonly AppsPermissionsRequestErrorEnum InvalidTrigger = new("invalid_trigger");

    public static readonly AppsPermissionsRequestErrorEnum TriggerExchanged = new("trigger_exchanged");

    public static readonly AppsPermissionsRequestErrorEnum InvalidScope = new("invalid_scope");

    public static readonly AppsPermissionsRequestErrorEnum InvalidUser = new("invalid_user");

    public static readonly AppsPermissionsRequestErrorEnum NotAuthed = new("not_authed");

    public static readonly AppsPermissionsRequestErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AppsPermissionsRequestErrorEnum AccountInactive = new("account_inactive");

    public static readonly AppsPermissionsRequestErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AppsPermissionsRequestErrorEnum NoPermission = new("no_permission");

    public static readonly AppsPermissionsRequestErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly AppsPermissionsRequestErrorEnum UserIsBot = new("user_is_bot");

    public static readonly AppsPermissionsRequestErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AppsPermissionsRequestErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AppsPermissionsRequestErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AppsPermissionsRequestErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AppsPermissionsRequestErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AppsPermissionsRequestErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AppsPermissionsRequestErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly AppsPermissionsRequestErrorEnum InvalidJson = new("invalid_json");

    public static readonly AppsPermissionsRequestErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AppsPermissionsRequestErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AppsPermissionsRequestErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly AppsPermissionsRequestErrorEnum FatalError = new("fatal_error");

    public static AppsPermissionsRequestErrorEnum FromValue(string value) => FromValueCore(value);
}
