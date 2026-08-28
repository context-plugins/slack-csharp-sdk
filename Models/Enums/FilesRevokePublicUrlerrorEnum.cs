using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesRevokePublicUrlErrorEnum>))]
public sealed record FilesRevokePublicUrlErrorEnum : StringEnum<FilesRevokePublicUrlErrorEnum>
{
    private FilesRevokePublicUrlErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesRevokePublicUrlErrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesRevokePublicUrlErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesRevokePublicUrlErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesRevokePublicUrlErrorEnum TokenRevoked = new("token_revoked");

    public static readonly FilesRevokePublicUrlErrorEnum NoPermission = new("no_permission");

    public static readonly FilesRevokePublicUrlErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly FilesRevokePublicUrlErrorEnum UserIsBot = new("user_is_bot");

    public static readonly FilesRevokePublicUrlErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesRevokePublicUrlErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesRevokePublicUrlErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesRevokePublicUrlErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesRevokePublicUrlErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesRevokePublicUrlErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesRevokePublicUrlErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly FilesRevokePublicUrlErrorEnum FatalError = new("fatal_error");

    public static FilesRevokePublicUrlErrorEnum FromValue(string value) => FromValueCore(value);
}
