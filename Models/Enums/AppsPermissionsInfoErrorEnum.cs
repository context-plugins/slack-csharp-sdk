using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AppsPermissionsInfoErrorEnum>))]
public sealed record AppsPermissionsInfoErrorEnum : StringEnum<AppsPermissionsInfoErrorEnum>
{
    private AppsPermissionsInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly AppsPermissionsInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly AppsPermissionsInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AppsPermissionsInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly AppsPermissionsInfoErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AppsPermissionsInfoErrorEnum NoPermission = new("no_permission");

    public static readonly AppsPermissionsInfoErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly AppsPermissionsInfoErrorEnum UserIsBot = new("user_is_bot");

    public static readonly AppsPermissionsInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AppsPermissionsInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AppsPermissionsInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AppsPermissionsInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AppsPermissionsInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AppsPermissionsInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AppsPermissionsInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly AppsPermissionsInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly AppsPermissionsInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AppsPermissionsInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AppsPermissionsInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly AppsPermissionsInfoErrorEnum FatalError = new("fatal_error");

    public static AppsPermissionsInfoErrorEnum FromValue(string value) => FromValueCore(value);
}
