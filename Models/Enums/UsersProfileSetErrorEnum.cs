using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersProfileSetErrorEnum>))]
public sealed record UsersProfileSetErrorEnum : StringEnum<UsersProfileSetErrorEnum>
{
    private UsersProfileSetErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersProfileSetErrorEnum ReservedName = new("reserved_name");

    public static readonly UsersProfileSetErrorEnum InvalidProfile = new("invalid_profile");

    public static readonly UsersProfileSetErrorEnum ProfileSetFailed = new("profile_set_failed");

    public static readonly UsersProfileSetErrorEnum NotAdmin = new("not_admin");

    public static readonly UsersProfileSetErrorEnum NotAppAdmin = new("not_app_admin");

    public static readonly UsersProfileSetErrorEnum CannotUpdateAdminUser = new("cannot_update_admin_user");

    public static readonly UsersProfileSetErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersProfileSetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersProfileSetErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersProfileSetErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersProfileSetErrorEnum NoPermission = new("no_permission");

    public static readonly UsersProfileSetErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersProfileSetErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsersProfileSetErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersProfileSetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersProfileSetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersProfileSetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersProfileSetErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersProfileSetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersProfileSetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersProfileSetErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersProfileSetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersProfileSetErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersProfileSetErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersProfileSetErrorEnum FatalError = new("fatal_error");

    public static UsersProfileSetErrorEnum FromValue(string value) => FromValueCore(value);
}
