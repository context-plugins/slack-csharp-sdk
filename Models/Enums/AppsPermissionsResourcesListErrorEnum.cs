using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AppsPermissionsResourcesListErrorEnum>))]
public sealed record AppsPermissionsResourcesListErrorEnum : StringEnum<AppsPermissionsResourcesListErrorEnum>
{
    private AppsPermissionsResourcesListErrorEnum(string value) : base(value)
    {
    }

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly AppsPermissionsResourcesListErrorEnum NotAuthed = new("not_authed");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AppsPermissionsResourcesListErrorEnum AccountInactive = new("account_inactive");

    public static readonly AppsPermissionsResourcesListErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AppsPermissionsResourcesListErrorEnum NoPermission = new("no_permission");

    public static readonly AppsPermissionsResourcesListErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly AppsPermissionsResourcesListErrorEnum UserIsBot = new("user_is_bot");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AppsPermissionsResourcesListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AppsPermissionsResourcesListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly AppsPermissionsResourcesListErrorEnum InvalidJson = new("invalid_json");

    public static readonly AppsPermissionsResourcesListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AppsPermissionsResourcesListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AppsPermissionsResourcesListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly AppsPermissionsResourcesListErrorEnum FatalError = new("fatal_error");

    public static AppsPermissionsResourcesListErrorEnum FromValue(string value) => FromValueCore(value);
}
