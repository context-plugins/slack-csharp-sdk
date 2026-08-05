using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AuthTestErrorEnum>))]
public sealed record AuthTestErrorEnum : StringEnum<AuthTestErrorEnum>
{
    private AuthTestErrorEnum(string value) : base(value)
    {
    }

    public static readonly AuthTestErrorEnum NotAuthed = new("not_authed");

    public static readonly AuthTestErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AuthTestErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AuthTestErrorEnum AccountInactive = new("account_inactive");

    public static readonly AuthTestErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AuthTestErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AuthTestErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AuthTestErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AuthTestErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AuthTestErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AuthTestErrorEnum InvalidJson = new("invalid_json");

    public static readonly AuthTestErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AuthTestErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AuthTestErrorEnum UpgradeRequired = new("upgrade_required");

    public static AuthTestErrorEnum FromValue(string value) => FromValueCore(value);
}
