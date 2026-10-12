using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RemindersCompleteErrorEnum>))]
public sealed record RemindersCompleteErrorEnum : OpenStringEnum<RemindersCompleteErrorEnum>
{
    private RemindersCompleteErrorEnum(string value) : base(value)
    {
    }

    public static readonly RemindersCompleteErrorEnum NotFound = new("not_found");

    public static readonly RemindersCompleteErrorEnum CannotCompleteRecurring = new("cannot_complete_recurring");

    public static readonly RemindersCompleteErrorEnum CannotCompleteOthers = new("cannot_complete_others");

    public static readonly RemindersCompleteErrorEnum NotAuthed = new("not_authed");

    public static readonly RemindersCompleteErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly RemindersCompleteErrorEnum AccountInactive = new("account_inactive");

    public static readonly RemindersCompleteErrorEnum TokenRevoked = new("token_revoked");

    public static readonly RemindersCompleteErrorEnum NoPermission = new("no_permission");

    public static readonly RemindersCompleteErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly RemindersCompleteErrorEnum UserIsBot = new("user_is_bot");

    public static readonly RemindersCompleteErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly RemindersCompleteErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly RemindersCompleteErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly RemindersCompleteErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly RemindersCompleteErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly RemindersCompleteErrorEnum MissingPostType = new("missing_post_type");

    public static readonly RemindersCompleteErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly RemindersCompleteErrorEnum InvalidJson = new("invalid_json");

    public static readonly RemindersCompleteErrorEnum JsonNotObject = new("json_not_object");

    public static readonly RemindersCompleteErrorEnum RequestTimeout = new("request_timeout");

    public static readonly RemindersCompleteErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly RemindersCompleteErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onNotFound,
        Func<TResult> onCannotCompleteRecurring,
        Func<TResult> onCannotCompleteOthers,
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
            _ when this == NotFound => onNotFound(),
            _ when this == CannotCompleteRecurring => onCannotCompleteRecurring(),
            _ when this == CannotCompleteOthers => onCannotCompleteOthers(),
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

    public void Match(Action onNotFound,
        Action onCannotCompleteRecurring,
        Action onCannotCompleteOthers,
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
        if (this == NotFound) onNotFound();
        else if (this == CannotCompleteRecurring) onCannotCompleteRecurring();
        else if (this == CannotCompleteOthers) onCannotCompleteOthers();
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
