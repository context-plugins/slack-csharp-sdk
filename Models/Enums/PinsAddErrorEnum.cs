using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinsAddErrorEnum>))]
public sealed record PinsAddErrorEnum : StringEnum<PinsAddErrorEnum>
{
    private PinsAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly PinsAddErrorEnum BadTimestamp = new("bad_timestamp");

    public static readonly PinsAddErrorEnum MessageNotFound = new("message_not_found");

    public static readonly PinsAddErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly PinsAddErrorEnum NoItemSpecified = new("no_item_specified");

    public static readonly PinsAddErrorEnum AlreadyPinned = new("already_pinned");

    public static readonly PinsAddErrorEnum PermissionDenied = new("permission_denied");

    public static readonly PinsAddErrorEnum FileNotShared = new("file_not_shared");

    public static readonly PinsAddErrorEnum NotPinnable = new("not_pinnable");

    public static readonly PinsAddErrorEnum NotAuthed = new("not_authed");

    public static readonly PinsAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly PinsAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly PinsAddErrorEnum NoPermission = new("no_permission");

    public static readonly PinsAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly PinsAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly PinsAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly PinsAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly PinsAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly PinsAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly PinsAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly PinsAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly PinsAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly PinsAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly PinsAddErrorEnum UpgradeRequired = new("upgrade_required");

    public static PinsAddErrorEnum FromValue(string value) => FromValueCore(value);
}
