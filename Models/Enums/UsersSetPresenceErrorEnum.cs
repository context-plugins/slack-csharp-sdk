using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersSetPresenceErrorEnum>))]
public sealed record UsersSetPresenceErrorEnum : StringEnum<UsersSetPresenceErrorEnum>
{
    private UsersSetPresenceErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersSetPresenceErrorEnum InvalidPresence = new("invalid_presence");

    public static readonly UsersSetPresenceErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersSetPresenceErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersSetPresenceErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersSetPresenceErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersSetPresenceErrorEnum NoPermission = new("no_permission");

    public static readonly UsersSetPresenceErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersSetPresenceErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersSetPresenceErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersSetPresenceErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersSetPresenceErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersSetPresenceErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersSetPresenceErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersSetPresenceErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersSetPresenceErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersSetPresenceErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersSetPresenceErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersSetPresenceErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersSetPresenceErrorEnum FatalError = new("fatal_error");

    public static UsersSetPresenceErrorEnum FromValue(string value) => FromValueCore(value);
}
