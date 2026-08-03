using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersListErrorEnum>))]
public sealed record UsersListErrorEnum : StringEnum<UsersListErrorEnum>
{
    private UsersListErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersListErrorEnum LimitRequired = new("limit_required");

    public static readonly UsersListErrorEnum InvalidCursor = new("invalid_cursor");

    public static readonly UsersListErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersListErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersListErrorEnum NoPermission = new("no_permission");

    public static readonly UsersListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersListErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersListErrorEnum FatalError = new("fatal_error");

    public static UsersListErrorEnum FromValue(string value) => FromValueCore(value);
}
