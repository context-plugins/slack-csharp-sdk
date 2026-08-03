using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersInfoErrorEnum>))]
public sealed record UsersInfoErrorEnum : StringEnum<UsersInfoErrorEnum>
{
    private UsersInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersInfoErrorEnum UserNotFound = new("user_not_found");

    public static readonly UsersInfoErrorEnum UserNotVisible = new("user_not_visible");

    public static readonly UsersInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static UsersInfoErrorEnum FromValue(string value) => FromValueCore(value);
}
