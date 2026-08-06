using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RtmConnectErrorEnum>))]
public sealed record RtmConnectErrorEnum : StringEnum<RtmConnectErrorEnum>
{
    private RtmConnectErrorEnum(string value) : base(value)
    {
    }

    public static readonly RtmConnectErrorEnum NotAuthed = new("not_authed");

    public static readonly RtmConnectErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly RtmConnectErrorEnum AccountInactive = new("account_inactive");

    public static readonly RtmConnectErrorEnum TokenRevoked = new("token_revoked");

    public static readonly RtmConnectErrorEnum NoPermission = new("no_permission");

    public static readonly RtmConnectErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly RtmConnectErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly RtmConnectErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly RtmConnectErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly RtmConnectErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly RtmConnectErrorEnum MissingPostType = new("missing_post_type");

    public static readonly RtmConnectErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly RtmConnectErrorEnum InvalidJson = new("invalid_json");

    public static readonly RtmConnectErrorEnum JsonNotObject = new("json_not_object");

    public static readonly RtmConnectErrorEnum RequestTimeout = new("request_timeout");

    public static readonly RtmConnectErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly RtmConnectErrorEnum FatalError = new("fatal_error");

    public static RtmConnectErrorEnum FromValue(string value) => FromValueCore(value);
}
