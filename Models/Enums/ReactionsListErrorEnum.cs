using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsListErrorEnum>))]
public sealed record ReactionsListErrorEnum : StringEnum<ReactionsListErrorEnum>
{
    private ReactionsListErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsListErrorEnum UserNotFound = new("user_not_found");

    public static readonly ReactionsListErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsListErrorEnum AccountInactiv = new("account_inactiv");

    public static readonly ReactionsListErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ReactionsListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsListErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsListErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ReactionsListErrorEnum FatalError = new("fatal_error");

    public static ReactionsListErrorEnum FromValue(string value) => FromValueCore(value);
}
