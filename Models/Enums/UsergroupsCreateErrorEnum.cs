using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsergroupsCreateErrorEnum>))]
public sealed record UsergroupsCreateErrorEnum : StringEnum<UsergroupsCreateErrorEnum>
{
    private UsergroupsCreateErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsergroupsCreateErrorEnum PermissionDenied = new("permission_denied");

    public static readonly UsergroupsCreateErrorEnum NotAuthed = new("not_authed");

    public static readonly UsergroupsCreateErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsergroupsCreateErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsergroupsCreateErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsergroupsCreateErrorEnum NoPermission = new("no_permission");

    public static readonly UsergroupsCreateErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsergroupsCreateErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsergroupsCreateErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly UsergroupsCreateErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsergroupsCreateErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsergroupsCreateErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsergroupsCreateErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsergroupsCreateErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsergroupsCreateErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsergroupsCreateErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsergroupsCreateErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsergroupsCreateErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsergroupsCreateErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsergroupsCreateErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsergroupsCreateErrorEnum FatalError = new("fatal_error");

    public static UsergroupsCreateErrorEnum FromValue(string value) => FromValueCore(value);
}
