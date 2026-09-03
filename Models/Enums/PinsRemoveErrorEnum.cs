using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinsRemoveErrorEnum>))]
public sealed record PinsRemoveErrorEnum : StringEnum<PinsRemoveErrorEnum>
{
    private PinsRemoveErrorEnum(string value) : base(value)
    {
    }

    public static readonly PinsRemoveErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly PinsRemoveErrorEnum FileNotFound = new("file_not_found");

    public static readonly PinsRemoveErrorEnum FileCommentNotFound = new("file_comment_not_found");

    public static readonly PinsRemoveErrorEnum MessageNotFound = new("message_not_found");

    public static readonly PinsRemoveErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly PinsRemoveErrorEnum NotPinned = new("not_pinned");

    public static readonly PinsRemoveErrorEnum PermissionDenied = new("permission_denied");

    public static readonly PinsRemoveErrorEnum NotAuthed = new("not_authed");

    public static readonly PinsRemoveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly PinsRemoveErrorEnum AccountInactive = new("account_inactive");

    public static readonly PinsRemoveErrorEnum NoPermission = new("no_permission");

    public static readonly PinsRemoveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly PinsRemoveErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly PinsRemoveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly PinsRemoveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly PinsRemoveErrorEnum InvalidPostTyp = new("invalid_post_typ");

    public static readonly PinsRemoveErrorEnum MissingPostTyp = new("missing_post_typ");

    public static readonly PinsRemoveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly PinsRemoveErrorEnum InvalidJson = new("invalid_json");

    public static readonly PinsRemoveErrorEnum JsonNotObject = new("json_not_object");

    public static readonly PinsRemoveErrorEnum RequestTimeou = new("request_timeou");

    public static readonly PinsRemoveErrorEnum UpgradeRequired = new("upgrade_required");

    public static PinsRemoveErrorEnum FromValue(string value) => FromValueCore(value);
}
