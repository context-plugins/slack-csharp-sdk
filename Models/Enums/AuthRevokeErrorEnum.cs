using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AuthRevokeErrorEnum>))]
public sealed record AuthRevokeErrorEnum : StringEnum<AuthRevokeErrorEnum>
{
    private AuthRevokeErrorEnum(string value) : base(value)
    {
    }

    public static readonly AuthRevokeErrorEnum NotAuthed = new("not_authed");

    public static readonly AuthRevokeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AuthRevokeErrorEnum AccountInactive = new("account_inactive");

    public static readonly AuthRevokeErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AuthRevokeErrorEnum NoPermission = new("no_permission");

    public static readonly AuthRevokeErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly AuthRevokeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AuthRevokeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AuthRevokeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AuthRevokeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AuthRevokeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AuthRevokeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AuthRevokeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly AuthRevokeErrorEnum InvalidJson = new("invalid_json");

    public static readonly AuthRevokeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AuthRevokeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AuthRevokeErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly AuthRevokeErrorEnum FatalError = new("fatal_error");

    public static AuthRevokeErrorEnum FromValue(string value) => FromValueCore(value);
}
