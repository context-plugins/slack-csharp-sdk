using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MigrationExchangeErrorEnum>))]
public sealed record MigrationExchangeErrorEnum : StringEnum<MigrationExchangeErrorEnum>
{
    private MigrationExchangeErrorEnum(string value) : base(value)
    {
    }

    public static readonly MigrationExchangeErrorEnum NotEnterpriseTeam = new("not_enterprise_team");

    public static readonly MigrationExchangeErrorEnum TooManyUsers = new("too_many_users");

    public static readonly MigrationExchangeErrorEnum NotAuthed = new("not_authed");

    public static readonly MigrationExchangeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly MigrationExchangeErrorEnum AccountInactive = new("account_inactive");

    public static readonly MigrationExchangeErrorEnum TokenRevoked = new("token_revoked");

    public static readonly MigrationExchangeErrorEnum NoPermission = new("no_permission");

    public static readonly MigrationExchangeErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly MigrationExchangeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly MigrationExchangeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly MigrationExchangeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly MigrationExchangeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly MigrationExchangeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly MigrationExchangeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly MigrationExchangeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly MigrationExchangeErrorEnum InvalidJson = new("invalid_json");

    public static readonly MigrationExchangeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly MigrationExchangeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly MigrationExchangeErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly MigrationExchangeErrorEnum FatalError = new("fatal_error");

    public static MigrationExchangeErrorEnum FromValue(string value) => FromValueCore(value);
}
