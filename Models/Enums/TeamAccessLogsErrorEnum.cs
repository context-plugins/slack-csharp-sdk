using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TeamAccessLogsErrorEnum>))]
public sealed record TeamAccessLogsErrorEnum : StringEnum<TeamAccessLogsErrorEnum>
{
    private TeamAccessLogsErrorEnum(string value) : base(value)
    {
    }

    public static readonly TeamAccessLogsErrorEnum PaidOnly = new("paid_only");

    public static readonly TeamAccessLogsErrorEnum OverPaginationLimit = new("over_pagination_limit");

    public static readonly TeamAccessLogsErrorEnum NotAuthed = new("not_authed");

    public static readonly TeamAccessLogsErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly TeamAccessLogsErrorEnum AccountInactive = new("account_inactive");

    public static readonly TeamAccessLogsErrorEnum TokenRevoked = new("token_revoked");

    public static readonly TeamAccessLogsErrorEnum NoPermission = new("no_permission");

    public static readonly TeamAccessLogsErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly TeamAccessLogsErrorEnum UserIsBot = new("user_is_bot");

    public static readonly TeamAccessLogsErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly TeamAccessLogsErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly TeamAccessLogsErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly TeamAccessLogsErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly TeamAccessLogsErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly TeamAccessLogsErrorEnum MissingPostType = new("missing_post_type");

    public static readonly TeamAccessLogsErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly TeamAccessLogsErrorEnum InvalidJson = new("invalid_json");

    public static readonly TeamAccessLogsErrorEnum JsonNotObject = new("json_not_object");

    public static readonly TeamAccessLogsErrorEnum RequestTimeout = new("request_timeout");

    public static readonly TeamAccessLogsErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly TeamAccessLogsErrorEnum FatalError = new("fatal_error");

    public static TeamAccessLogsErrorEnum FromValue(string value) => FromValueCore(value);
}
