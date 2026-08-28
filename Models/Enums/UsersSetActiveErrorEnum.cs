using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersSetActiveErrorEnum>))]
public sealed record UsersSetActiveErrorEnum : StringEnum<UsersSetActiveErrorEnum>
{
    private UsersSetActiveErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersSetActiveErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersSetActiveErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersSetActiveErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersSetActiveErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersSetActiveErrorEnum NoPermission = new("no_permission");

    public static readonly UsersSetActiveErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersSetActiveErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly UsersSetActiveErrorEnum MissingScope = new("missing_scope");

    public static readonly UsersSetActiveErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly UsersSetActiveErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersSetActiveErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersSetActiveErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersSetActiveErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersSetActiveErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersSetActiveErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersSetActiveErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersSetActiveErrorEnum FatalError = new("fatal_error");

    public static readonly UsersSetActiveErrorEnum InternalError = new("internal_error");

    public static UsersSetActiveErrorEnum FromValue(string value) => FromValueCore(value);
}
