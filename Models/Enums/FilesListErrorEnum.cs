using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesListErrorEnum>))]
public sealed record FilesListErrorEnum : StringEnum<FilesListErrorEnum>
{
    private FilesListErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesListErrorEnum UserNotFound = new("user_not_found");

    public static readonly FilesListErrorEnum UnknownType = new("unknown_type");

    public static readonly FilesListErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesListErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesListErrorEnum NoPermission = new("no_permission");

    public static readonly FilesListErrorEnum UserIsBot = new("user_is_bot");

    public static readonly FilesListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesListErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesListErrorEnum UpgradeRequired = new("upgrade_required");

    public static FilesListErrorEnum FromValue(string value) => FromValueCore(value);
}
