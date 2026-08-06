using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersProfileGetErrorEnum>))]
public sealed record UsersProfileGetErrorEnum : StringEnum<UsersProfileGetErrorEnum>
{
    private UsersProfileGetErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersProfileGetErrorEnum UserNotFound = new("user_not_found");

    public static readonly UsersProfileGetErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersProfileGetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersProfileGetErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersProfileGetErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersProfileGetErrorEnum NoPermission = new("no_permission");

    public static readonly UsersProfileGetErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersProfileGetErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsersProfileGetErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersProfileGetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersProfileGetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersProfileGetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersProfileGetErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersProfileGetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersProfileGetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersProfileGetErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersProfileGetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersProfileGetErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersProfileGetErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersProfileGetErrorEnum FatalError = new("fatal_error");

    public static UsersProfileGetErrorEnum FromValue(string value) => FromValueCore(value);
}
