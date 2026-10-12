using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AppsUninstallErrorEnum>))]
public sealed record AppsUninstallErrorEnum : OpenStringEnum<AppsUninstallErrorEnum>
{
    private AppsUninstallErrorEnum(string value) : base(value)
    {
    }

    public static readonly AppsUninstallErrorEnum InvalidClientId = new("invalid_client_id");

    public static readonly AppsUninstallErrorEnum BadClientSecret = new("bad_client_secret");

    public static readonly AppsUninstallErrorEnum ClientIdTokenMismatch = new("client_id_token_mismatch");

    public static readonly AppsUninstallErrorEnum NotAuthed = new("not_authed");

    public static readonly AppsUninstallErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly AppsUninstallErrorEnum AccountInactive = new("account_inactive");

    public static readonly AppsUninstallErrorEnum TokenRevoked = new("token_revoked");

    public static readonly AppsUninstallErrorEnum NoPermission = new("no_permission");

    public static readonly AppsUninstallErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly AppsUninstallErrorEnum UserIsBot = new("user_is_bot");

    public static readonly AppsUninstallErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly AppsUninstallErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly AppsUninstallErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly AppsUninstallErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly AppsUninstallErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly AppsUninstallErrorEnum MissingPostType = new("missing_post_type");

    public static readonly AppsUninstallErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly AppsUninstallErrorEnum InvalidJson = new("invalid_json");

    public static readonly AppsUninstallErrorEnum JsonNotObject = new("json_not_object");

    public static readonly AppsUninstallErrorEnum RequestTimeout = new("request_timeout");

    public static readonly AppsUninstallErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly AppsUninstallErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onInvalidClientId,
        Func<TResult> onBadClientSecret,
        Func<TResult> onClientIdTokenMismatch,
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
            _ when this == InvalidClientId => onInvalidClientId(),
            _ when this == BadClientSecret => onBadClientSecret(),
            _ when this == ClientIdTokenMismatch => onClientIdTokenMismatch(),
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

    public void Match(Action onInvalidClientId,
        Action onBadClientSecret,
        Action onClientIdTokenMismatch,
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
        if (this == InvalidClientId) onInvalidClientId();
        else if (this == BadClientSecret) onBadClientSecret();
        else if (this == ClientIdTokenMismatch) onClientIdTokenMismatch();
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
