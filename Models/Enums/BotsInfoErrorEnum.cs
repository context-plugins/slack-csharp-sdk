using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BotsInfoErrorEnum>))]
public sealed record BotsInfoErrorEnum : StringEnum<BotsInfoErrorEnum>
{
    private BotsInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly BotsInfoErrorEnum BotNotFound = new("bot_not_found");

    public static readonly BotsInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly BotsInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly BotsInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly BotsInfoErrorEnum TokenRevoked = new("token_revoked");

    public static readonly BotsInfoErrorEnum NoPermission = new("no_permission");

    public static readonly BotsInfoErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly BotsInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly BotsInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly BotsInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly BotsInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly BotsInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly BotsInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly BotsInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly BotsInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly BotsInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly BotsInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly BotsInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly BotsInfoErrorEnum FatalError = new("fatal_error");

    public static BotsInfoErrorEnum FromValue(string value) => FromValueCore(value);
}
