using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<UsergroupsUpdateErrorEnum>))]
public sealed record UsergroupsUpdateErrorEnum : OpenStringEnum<UsergroupsUpdateErrorEnum>
{
    private UsergroupsUpdateErrorEnum(string value) : base(value)
    {
    }

    public static readonly UsergroupsUpdateErrorEnum PermissionDenied = new("permission_denied");

    public static readonly UsergroupsUpdateErrorEnum NotAuthed = new("not_authed");

    public static readonly UsergroupsUpdateErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly UsergroupsUpdateErrorEnum AccountInactive = new("account_inactive");

    public static readonly UsergroupsUpdateErrorEnum TokenRevoked = new("token_revoked");

    public static readonly UsergroupsUpdateErrorEnum NoPermission = new("no_permission");

    public static readonly UsergroupsUpdateErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly UsergroupsUpdateErrorEnum UserIsBot = new("user_is_bot");

    public static readonly UsergroupsUpdateErrorEnum UserIsRestricted = new("user_is_restricted");

    public static readonly UsergroupsUpdateErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly UsergroupsUpdateErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly UsergroupsUpdateErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly UsergroupsUpdateErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly UsergroupsUpdateErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly UsergroupsUpdateErrorEnum MissingPostType = new("missing_post_type");

    public static readonly UsergroupsUpdateErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly UsergroupsUpdateErrorEnum InvalidJson = new("invalid_json");

    public static readonly UsergroupsUpdateErrorEnum JsonNotObject = new("json_not_object");

    public static readonly UsergroupsUpdateErrorEnum RequestTimeout = new("request_timeout");

    public static readonly UsergroupsUpdateErrorEnum UpgradeRequire = new("upgrade_require");

    public static readonly UsergroupsUpdateErrorEnum FatalError = new("fatal_error");

    public static readonly UsergroupsUpdateErrorEnum MissingCharset = new("missing_charset");

    public static readonly UsergroupsUpdateErrorEnum SuperfluousCharset = new("superfluous_charset");

    public TResult Match<TResult>(Func<TResult> onPermissionDenied,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
        Func<TResult> onUserIsBot,
        Func<TResult> onUserIsRestricted,
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
        Func<TResult> onUpgradeRequire,
        Func<TResult> onFatalError,
        Func<TResult> onMissingCharset,
        Func<TResult> onSuperfluousCharset,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PermissionDenied => onPermissionDenied(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
            _ when this == UserIsBot => onUserIsBot(),
            _ when this == UserIsRestricted => onUserIsRestricted(),
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
            _ when this == UpgradeRequire => onUpgradeRequire(),
            _ when this == FatalError => onFatalError(),
            _ when this == MissingCharset => onMissingCharset(),
            _ when this == SuperfluousCharset => onSuperfluousCharset(),
            _ => otherwise(Value)
        };

    public void Match(Action onPermissionDenied,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
        Action onUserIsBot,
        Action onUserIsRestricted,
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
        Action onUpgradeRequire,
        Action onFatalError,
        Action onMissingCharset,
        Action onSuperfluousCharset,
        Action<string> otherwise)
    {
        if (this == PermissionDenied) onPermissionDenied();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
        else if (this == UserIsBot) onUserIsBot();
        else if (this == UserIsRestricted) onUserIsRestricted();
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
        else if (this == UpgradeRequire) onUpgradeRequire();
        else if (this == FatalError) onFatalError();
        else if (this == MissingCharset) onMissingCharset();
        else if (this == SuperfluousCharset) onSuperfluousCharset();
        else otherwise(Value);
    }
}
