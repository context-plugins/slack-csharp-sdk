using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DndInfoErrorEnum>))]
public sealed record DndInfoErrorEnum : OpenStringEnum<DndInfoErrorEnum>
{
    private DndInfoErrorEnum(string value) : base(value)
    {
    }

    public static readonly DndInfoErrorEnum UserNotFound = new("user_not_found");

    public static readonly DndInfoErrorEnum NotAuthed = new("not_authed");

    public static readonly DndInfoErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DndInfoErrorEnum AccountInactive = new("account_inactive");

    public static readonly DndInfoErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DndInfoErrorEnum NoPermission = new("no_permission");

    public static readonly DndInfoErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DndInfoErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DndInfoErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DndInfoErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DndInfoErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DndInfoErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DndInfoErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DndInfoErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DndInfoErrorEnum InvalidJson = new("invalid_json");

    public static readonly DndInfoErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DndInfoErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DndInfoErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DndInfoErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onUserNotFound,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
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
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
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

    public void Match(Action onUserNotFound,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
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
        if (this == UserNotFound) onUserNotFound();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
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
