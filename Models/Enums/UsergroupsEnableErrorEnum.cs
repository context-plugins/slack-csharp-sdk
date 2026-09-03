using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsergroupsEnableErrorEnum>))]
public sealed record UsergroupsEnableErrorEnum : StringEnum<UsergroupsEnableErrorEnum>
{
    private UsergroupsEnableErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsergroupsEnableErrorEnum NotAuthed = new("not_authed");

    public static readonly UsergroupsEnableErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsergroupsEnableErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsergroupsEnableErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsergroupsEnableErrorEnum NoPermission = new("no_permission");

    public static readonly UsergroupsEnableErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsergroupsEnableErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsergroupsEnableErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly UsergroupsEnableErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsergroupsEnableErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsergroupsEnableErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsergroupsEnableErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsergroupsEnableErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsergroupsEnableErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsergroupsEnableErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsergroupsEnableErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsergroupsEnableErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsergroupsEnableErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsergroupsEnableErrorEnum UpgradeRequire = new("upgrade_require");

    public static readonly UsergroupsEnableErrorEnum FatalError = new("fatal_error");

    public static readonly UsergroupsEnableErrorEnum MissingCharset = new("missing_charset");

    public static readonly UsergroupsEnableErrorEnum SuperfluousCharset = new("superfluous_charset");

    public static UsergroupsEnableErrorEnum FromValue(string value) => FromValueCore(value);
}
