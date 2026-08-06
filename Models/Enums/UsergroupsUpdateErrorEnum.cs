using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsergroupsUpdateErrorEnum>))]
public sealed record UsergroupsUpdateErrorEnum : StringEnum<UsergroupsUpdateErrorEnum>
{
    private UsergroupsUpdateErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsergroupsUpdateErrorEnum PermissionDenied = new("permission_denied");

    public static readonly UsergroupsUpdateErrorEnum NotAuthed = new("not_authed");

    public static readonly UsergroupsUpdateErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsergroupsUpdateErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsergroupsUpdateErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsergroupsUpdateErrorEnum NoPermission = new("no_permission");

    public static readonly UsergroupsUpdateErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsergroupsUpdateErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsergroupsUpdateErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly UsergroupsUpdateErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsergroupsUpdateErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsergroupsUpdateErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsergroupsUpdateErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsergroupsUpdateErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsergroupsUpdateErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsergroupsUpdateErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsergroupsUpdateErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsergroupsUpdateErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsergroupsUpdateErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsergroupsUpdateErrorEnum UpgradeRequire = new("upgrade_require");

    public static readonly UsergroupsUpdateErrorEnum FatalError = new("fatal_error");

    public static readonly UsergroupsUpdateErrorEnum MissingCharset = new("missing_charset");

    public static readonly UsergroupsUpdateErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static UsergroupsUpdateErrorEnum FromValue(string value) => FromValueCore(value);
}
