using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ReactionsGetErrorEnum>))]
public sealed record ReactionsGetErrorEnum : StringEnum<ReactionsGetErrorEnum>
{
    private ReactionsGetErrorEnum(string value) : base(value)
    {
    }

    public static readonly ReactionsGetErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly ReactionsGetErrorEnum FileNotFound = new("file_not_found");

    public static readonly ReactionsGetErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly ReactionsGetErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ReactionsGetErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly ReactionsGetErrorEnum NotAuthed = new("not_authed");

    public static readonly ReactionsGetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ReactionsGetErrorEnum AccountInactive = new("account_inactive");

    public static readonly ReactionsGetErrorEnum NoPermission = new("no_permission");

    public static readonly ReactionsGetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ReactionsGetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ReactionsGetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ReactionsGetErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ReactionsGetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ReactionsGetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ReactionsGetErrorEnum InvalidJson = new("invalid_json");

    public static readonly ReactionsGetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ReactionsGetErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ReactionsGetErrorEnum UpgradeRequired = new("upgrade_required");

    public static ReactionsGetErrorEnum FromValue(string value) => FromValueCore(value);
}
