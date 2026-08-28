using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesSharedPublicUrlErrorEnum>))]
public sealed record FilesSharedPublicUrlErrorEnum : StringEnum<FilesSharedPublicUrlErrorEnum>
{
    private FilesSharedPublicUrlErrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesSharedPublicUrlErrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesSharedPublicUrlErrorEnum NotAllowed = new("not_allowed");

    public static readonly FilesSharedPublicUrlErrorEnum NotAuthed = new("not_authed");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesSharedPublicUrlErrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesSharedPublicUrlErrorEnum TokenRevoked = new("token_revoked");

    public static readonly FilesSharedPublicUrlErrorEnum NoPermission = new("no_permission");

    public static readonly FilesSharedPublicUrlErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly FilesSharedPublicUrlErrorEnum UserIsBot = new("user_is_bot");

    public static readonly FilesSharedPublicUrlErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesSharedPublicUrlErrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesSharedPublicUrlErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesSharedPublicUrlErrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesSharedPublicUrlErrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesSharedPublicUrlErrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesSharedPublicUrlErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly FilesSharedPublicUrlErrorEnum FatalError = new("fatal_error");

    public static FilesSharedPublicUrlErrorEnum FromValue(string value) => FromValueCore(value);
}
