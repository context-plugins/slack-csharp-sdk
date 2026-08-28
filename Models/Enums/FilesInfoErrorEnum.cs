using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesInfoErrorEnum>))]
public sealed record FilesInfoErrorEnum : StringEnum<FilesInfoErrorEnum>
{
    private FilesInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesInfoErrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesInfoErrorEnum FileDeleted = new("file_deleted");

    public static readonly FilesInfoErrorEnum TimezoneCountFailed = new("timezone_count_failed");

    public static readonly FilesInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesInfoErrorEnum NoPermission = new("no_permission");

    public static readonly FilesInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static FilesInfoErrorEnum FromValue(string value) => FromValueCore(value);
}
