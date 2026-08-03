using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RemindersDeleteErrorEnum>))]
public sealed record RemindersDeleteErrorEnum : StringEnum<RemindersDeleteErrorEnum>
{
    private RemindersDeleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly RemindersDeleteErrorEnum NotFound = new("not_found");

    public static readonly RemindersDeleteErrorEnum NotAuthed = new("not_authed");

    public static readonly RemindersDeleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly RemindersDeleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly RemindersDeleteErrorEnum TokenRevoked = new("token_revoked");

    public static readonly RemindersDeleteErrorEnum NoPermission = new("no_permission");

    public static readonly RemindersDeleteErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly RemindersDeleteErrorEnum UserIsBot = new("user_is_bot");

    public static readonly RemindersDeleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly RemindersDeleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly RemindersDeleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly RemindersDeleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly RemindersDeleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly RemindersDeleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly RemindersDeleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly RemindersDeleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly RemindersDeleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly RemindersDeleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly RemindersDeleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly RemindersDeleteErrorEnum FatalError = new("fatal_error");

    public static RemindersDeleteErrorEnum FromValue(string value) => FromValueCore(value);
}
