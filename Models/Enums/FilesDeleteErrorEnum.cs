using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesDeleteErrorEnum>))]
public sealed record FilesDeleteErrorEnum : StringEnum<FilesDeleteErrorEnum>
{
    private FilesDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesDeleteErrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesDeleteErrorEnum FileDeleted = new("file_deleted");

    public static readonly FilesDeleteErrorEnum CantDeleteFile = new("cant_delete_file");

    public static readonly FilesDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly FilesDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesDeleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static FilesDeleteErrorEnum FromValue(string value) => FromValueCore(value);
}
