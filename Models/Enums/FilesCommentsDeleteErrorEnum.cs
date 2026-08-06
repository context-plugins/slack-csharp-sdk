using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesCommentsDeleteErrorEnum>))]
public sealed record FilesCommentsDeleteErrorEnum : StringEnum<FilesCommentsDeleteErrorEnum>
{
    private FilesCommentsDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesCommentsDeleteErrorEnum CantDelete = new("cant_delete");

    public static readonly FilesCommentsDeleteErrorEnum CommentNotFound = new("comment_not_found");

    public static readonly FilesCommentsDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesCommentsDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesCommentsDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesCommentsDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly FilesCommentsDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesCommentsDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesCommentsDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesCommentsDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesCommentsDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesCommentsDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesCommentsDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesCommentsDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesCommentsDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesCommentsDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static FilesCommentsDeleteErrorEnum FromValue(string value) => FromValueCore(value);
}
