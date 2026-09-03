using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TeamProfileGetErrorEnum>))]
public sealed record TeamProfileGetErrorEnum : StringEnum<TeamProfileGetErrorEnum>
{
    private TeamProfileGetErrorEnum(string value) : base(value)
    {
    }

    public static readonly TeamProfileGetErrorEnum NotAuthed = new("not_authed");

    public static readonly TeamProfileGetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly TeamProfileGetErrorEnum AccountInactive = new("account_inactive");

    public static readonly TeamProfileGetErrorEnum NoPermission = new("no_permission");

    public static readonly TeamProfileGetErrorEnum UserIsBot = new("user_is_bot");

    public static readonly TeamProfileGetErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly TeamProfileGetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly TeamProfileGetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly TeamProfileGetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly TeamProfileGetErrorEnum InvalidPostTyp = new("invalid_post_typ");

    public static readonly TeamProfileGetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly TeamProfileGetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly TeamProfileGetErrorEnum InvalidJson = new("invalid_json");

    public static readonly TeamProfileGetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly TeamProfileGetErrorEnum RequestTimeou = new("request_timeou");

    public static readonly TeamProfileGetErrorEnum UpgradeRequired = new("upgrade_required");

    public static TeamProfileGetErrorEnum FromValue(string value) => FromValueCore(value);
}
