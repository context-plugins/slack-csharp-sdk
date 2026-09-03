using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinsListErrorEnum>))]
public sealed record PinsListErrorEnum : StringEnum<PinsListErrorEnum>
{
    private PinsListErrorEnum(string value) : base(value)
    {
    }

    public static readonly PinsListErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly PinsListErrorEnum NotAuthed = new("not_authed");

    public static readonly PinsListErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly PinsListErrorEnum AccountInactive = new("account_inactive");

    public static readonly PinsListErrorEnum NoPermission = new("no_permission");

    public static readonly PinsListErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly PinsListErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly PinsListErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly PinsListErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly PinsListErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly PinsListErrorEnum MissingPostType = new("missing_post_type");

    public static readonly PinsListErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly PinsListErrorEnum InvalidJson = new("invalid_json");

    public static readonly PinsListErrorEnum JsonNotObject = new("json_not_object");

    public static readonly PinsListErrorEnum RequestTimeout = new("request_timeout");

    public static readonly PinsListErrorEnum UpgradeRequired = new("upgrade_required");

    public static PinsListErrorEnum FromValue(string value) => FromValueCore(value);
}
