using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsersProfileSetErrorEnum>))]
public sealed record UsersProfileSetErrorEnum : OpenStringEnum<UsersProfileSetErrorEnum>
{
    private UsersProfileSetErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsersProfileSetErrorEnum ReservedName = new("reserved_name");

    public static readonly UsersProfileSetErrorEnum InvalidProfile = new("invalid_profile");

    public static readonly UsersProfileSetErrorEnum ProfileSetFailed = new("profile_set_failed");

    public static readonly UsersProfileSetErrorEnum NotAdmin = new("not_admin");

    public static readonly UsersProfileSetErrorEnum NotAppAdmin = new("not_app_admin");

    public static readonly UsersProfileSetErrorEnum CannotUpdateAdminUser = new("cannot_update_admin_user");

    public static readonly UsersProfileSetErrorEnum NotAuthed = new("not_authed");

    public static readonly UsersProfileSetErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsersProfileSetErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsersProfileSetErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsersProfileSetErrorEnum NoPermission = new("no_permission");

    public static readonly UsersProfileSetErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsersProfileSetErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsersProfileSetErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsersProfileSetErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsersProfileSetErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsersProfileSetErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsersProfileSetErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsersProfileSetErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsersProfileSetErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsersProfileSetErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsersProfileSetErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsersProfileSetErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsersProfileSetErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly UsersProfileSetErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onReservedName,
        Func<TResult> onInvalidProfile,
        Func<TResult> onProfileSetFailed,
        Func<TResult> onNotAdmin,
        Func<TResult> onNotAppAdmin,
        Func<TResult> onCannotUpdateAdminUser,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
        Func<TResult> onUserIsBot,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onTeamAddedToOrg,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeout,
        Func<TResult> onUpgradeRequired,
        Func<TResult> onFatalError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ReservedName => onReservedName(),
            _ when this == InvalidProfile => onInvalidProfile(),
            _ when this == ProfileSetFailed => onProfileSetFailed(),
            _ when this == NotAdmin => onNotAdmin(),
            _ when this == NotAppAdmin => onNotAppAdmin(),
            _ when this == CannotUpdateAdminUser => onCannotUpdateAdminUser(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
            _ when this == UserIsBot => onUserIsBot(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == TeamAddedToOrg => onTeamAddedToOrg(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ when this == FatalError => onFatalError(),
            _ => otherwise(Value)
        };

    public void Match(Action onReservedName,
        Action onInvalidProfile,
        Action onProfileSetFailed,
        Action onNotAdmin,
        Action onNotAppAdmin,
        Action onCannotUpdateAdminUser,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
        Action onUserIsBot,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onTeamAddedToOrg,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeout,
        Action onUpgradeRequired,
        Action onFatalError,
        Action<string> otherwise)
    {
        if (this == ReservedName) onReservedName();
        else if (this == InvalidProfile) onInvalidProfile();
        else if (this == ProfileSetFailed) onProfileSetFailed();
        else if (this == NotAdmin) onNotAdmin();
        else if (this == NotAppAdmin) onNotAppAdmin();
        else if (this == CannotUpdateAdminUser) onCannotUpdateAdminUser();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
        else if (this == UserIsBot) onUserIsBot();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == TeamAddedToOrg) onTeamAddedToOrg();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else if (this == FatalError) onFatalError();
        else otherwise(Value);
    }
}
