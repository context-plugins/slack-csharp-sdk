using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AppsUninstallErrorEnum>))]
public sealed record AppsUninstallErrorEnum : StringEnum<AppsUninstallErrorEnum>
{
    private AppsUninstallErrorEnum(string value) : base(value)
    {
    }

    public static readonly AppsUninstallErrorEnum InvalidClientId = new("invalid_client_id");

    public static readonly AppsUninstallErrorEnum BadClientSecret = new("bad_client_secret");

    public static readonly AppsUninstallErrorEnum ClientIdTokenMismatch = new("client_id_token_mismatch");

    public static readonly AppsUninstallErrorEnum NotAuthed = new("not_authed");

    public static readonly AppsUninstallErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AppsUninstallErrorEnum AccountInactive = new("account_inactive");

    public static readonly AppsUninstallErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AppsUninstallErrorEnum NoPermission = new("no_permission");

    public static readonly AppsUninstallErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly AppsUninstallErrorEnum UserIsBot = new("user_is_bot");

    public static readonly AppsUninstallErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AppsUninstallErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AppsUninstallErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AppsUninstallErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AppsUninstallErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AppsUninstallErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AppsUninstallErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly AppsUninstallErrorEnum InvalidJson = new("invalid_json");

    public static readonly AppsUninstallErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AppsUninstallErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AppsUninstallErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly AppsUninstallErrorEnum FatalError = new("fatal_error");

    public static AppsUninstallErrorEnum FromValue(string value) => FromValueCore(value);
}
