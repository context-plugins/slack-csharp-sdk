using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersLookupByEmailErrorEnum>))]
public sealed record UsersLookupByEmailErrorEnum : StringEnum<UsersLookupByEmailErrorEnum>
{
    private UsersLookupByEmailErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersLookupByEmailErrorEnum UsersNotFound = new("users_not_found");

    public static readonly UsersLookupByEmailErrorEnum EnterpriseIsRestricted = new("enterprise_is_restricted");

    public static readonly UsersLookupByEmailErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersLookupByEmailErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersLookupByEmailErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersLookupByEmailErrorEnum NoPermission = new("no_permission");

    public static readonly UsersLookupByEmailErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersLookupByEmailErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersLookupByEmailErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersLookupByEmailErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersLookupByEmailErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersLookupByEmailErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersLookupByEmailErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersLookupByEmailErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersLookupByEmailErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersLookupByEmailErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersLookupByEmailErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersLookupByEmailErrorEnum FatalError = new("fatal_error");

    public static UsersLookupByEmailErrorEnum FromValue(string value) => FromValueCore(value);
}
