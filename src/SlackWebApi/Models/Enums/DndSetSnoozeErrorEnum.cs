using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DndSetSnoozeErrorEnum>))]
public sealed record DndSetSnoozeErrorEnum : OpenStringEnum<DndSetSnoozeErrorEnum>
{
    private DndSetSnoozeErrorEnum(string value) : base(value)
    {
    }

    public static readonly DndSetSnoozeErrorEnum MissingDuration = new("missing_duration");

    public static readonly DndSetSnoozeErrorEnum SnoozeFailed = new("snooze_failed");

    public static readonly DndSetSnoozeErrorEnum NotAuthed = new("not_authed");

    public static readonly DndSetSnoozeErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DndSetSnoozeErrorEnum AccountInactive = new("account_inactive");

    public static readonly DndSetSnoozeErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DndSetSnoozeErrorEnum NoPermission = new("no_permission");

    public static readonly DndSetSnoozeErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DndSetSnoozeErrorEnum UserIsBot = new("user_is_bot");

    public static readonly DndSetSnoozeErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DndSetSnoozeErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DndSetSnoozeErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DndSetSnoozeErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DndSetSnoozeErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DndSetSnoozeErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DndSetSnoozeErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DndSetSnoozeErrorEnum InvalidJson = new("invalid_json");

    public static readonly DndSetSnoozeErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DndSetSnoozeErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DndSetSnoozeErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DndSetSnoozeErrorEnum TooLong = new("too_long");

    public static readonly DndSetSnoozeErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onMissingDuration,
        Func<TResult> onSnoozeFailed,
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
        Func<TResult> onTooLong,
        Func<TResult> onFatalError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MissingDuration => onMissingDuration(),
            _ when this == SnoozeFailed => onSnoozeFailed(),
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
            _ when this == TooLong => onTooLong(),
            _ when this == FatalError => onFatalError(),
            _ => otherwise(Value)
        };

    public void Match(Action onMissingDuration,
        Action onSnoozeFailed,
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
        Action onTooLong,
        Action onFatalError,
        Action<string> otherwise)
    {
        if (this == MissingDuration) onMissingDuration();
        else if (this == SnoozeFailed) onSnoozeFailed();
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
        else if (this == TooLong) onTooLong();
        else if (this == FatalError) onFatalError();
        else otherwise(Value);
    }
}
