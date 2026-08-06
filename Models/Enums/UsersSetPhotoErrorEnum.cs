using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersSetPhotoErrorEnum>))]
public sealed record UsersSetPhotoErrorEnum : StringEnum<UsersSetPhotoErrorEnum>
{
    private UsersSetPhotoErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersSetPhotoErrorEnum BadImage = new("bad_image");

    public static readonly UsersSetPhotoErrorEnum TooLarge = new("too_large");

    public static readonly UsersSetPhotoErrorEnum TooManyFrames = new("too_many_frames");

    public static readonly UsersSetPhotoErrorEnum NotFound = new("not_found");

    public static readonly UsersSetPhotoErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersSetPhotoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersSetPhotoErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersSetPhotoErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersSetPhotoErrorEnum NoPermission = new("no_permission");

    public static readonly UsersSetPhotoErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersSetPhotoErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsersSetPhotoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersSetPhotoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersSetPhotoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersSetPhotoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersSetPhotoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersSetPhotoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersSetPhotoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersSetPhotoErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersSetPhotoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersSetPhotoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersSetPhotoErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersSetPhotoErrorEnum FatalError = new("fatal_error");

    public static UsersSetPhotoErrorEnum FromValue(string value) => FromValueCore(value);
}
