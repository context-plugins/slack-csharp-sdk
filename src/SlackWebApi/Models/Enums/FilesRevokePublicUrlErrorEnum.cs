using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FilesRevokePublicUrlErrorEnum>))]
public sealed record FilesRevokePublicUrlErrorEnum : OpenStringEnum<FilesRevokePublicUrlErrorEnum>
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

    public TResult Match<TResult>(Func<TResult> onFileNotFound,
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
        Func<TResult> onUpgradeRequired,
        Func<TResult> onFatalError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FileNotFound => onFileNotFound(),
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
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ when this == FatalError => onFatalError(),
            _ => otherwise(Value)
        };

    public void Match(Action onFileNotFound,
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
        Action onUpgradeRequired,
        Action onFatalError,
        Action<string> otherwise)
    {
        if (this == FileNotFound) onFileNotFound();
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
        else if (this == UpgradeRequired) onUpgradeRequired();
        else if (this == FatalError) onFatalError();
        else otherwise(Value);
    }
}
