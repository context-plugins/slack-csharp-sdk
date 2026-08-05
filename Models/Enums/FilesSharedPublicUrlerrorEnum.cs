using System.Text.Json.Serialization;
using Slack.Core.Enum;

namespace Slack.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesSharedPublicUrlerrorEnum>))]
public sealed record FilesSharedPublicUrlerrorEnum : StringEnum<FilesSharedPublicUrlerrorEnum>
{
    private FilesSharedPublicUrlerrorEnum(string value) : base(value)
    {
    }

    public static readonly FilesSharedPublicUrlerrorEnum FileNotFound = new("file_not_found");

    public static readonly FilesSharedPublicUrlerrorEnum NotAllowed = new("not_allowed");

    public static readonly FilesSharedPublicUrlerrorEnum NotAuthed = new("not_authed");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidAuth = new("invalid_auth");

    public static readonly FilesSharedPublicUrlerrorEnum AccountInactive = new("account_inactive");

    public static readonly FilesSharedPublicUrlerrorEnum TokenRevoked = new("token_revoked");

    public static readonly FilesSharedPublicUrlerrorEnum NoPermission = new("no_permission");

    public static readonly FilesSharedPublicUrlerrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly FilesSharedPublicUrlerrorEnum UserIsBot = new("user_is_bot");

    public static readonly FilesSharedPublicUrlerrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidCharset = new("invalid_charset");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly FilesSharedPublicUrlerrorEnum MissingPostType = new("missing_post_type");

    public static readonly FilesSharedPublicUrlerrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly FilesSharedPublicUrlerrorEnum InvalidJson = new("invalid_json");

    public static readonly FilesSharedPublicUrlerrorEnum JsonNotObject = new("json_not_object");

    public static readonly FilesSharedPublicUrlerrorEnum RequestTimeout = new("request_timeout");

    public static readonly FilesSharedPublicUrlerrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly FilesSharedPublicUrlerrorEnum FatalError = new("fatal_error");

    public static FilesSharedPublicUrlerrorEnum FromValue(string value) => FromValueCore(value);
}
