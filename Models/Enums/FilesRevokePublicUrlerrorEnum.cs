using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesRevokePublicUrlerrorEnum>))]
public sealed record FilesRevokePublicUrlerrorEnum : StringEnum<FilesRevokePublicUrlerrorEnum>
{
    private FilesRevokePublicUrlerrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesRevokePublicUrlerrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesRevokePublicUrlerrorEnum NotAuthed = new("not_authed");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesRevokePublicUrlerrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesRevokePublicUrlerrorEnum TokenRevoked = new("token_revoked");

    public static readonly FilesRevokePublicUrlerrorEnum NoPermission = new("no_permission");

    public static readonly FilesRevokePublicUrlerrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly FilesRevokePublicUrlerrorEnum UserIsBot = new("user_is_bot");

    public static readonly FilesRevokePublicUrlerrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesRevokePublicUrlerrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesRevokePublicUrlerrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesRevokePublicUrlerrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesRevokePublicUrlerrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesRevokePublicUrlerrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesRevokePublicUrlerrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly FilesRevokePublicUrlerrorEnum FatalError = new("fatal_error");

    public static FilesRevokePublicUrlerrorEnum FromValue(string value) => FromValueCore(value);
}
