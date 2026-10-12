using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RemindersAddErrorEnum>))]
public sealed record RemindersAddErrorEnum : OpenStringEnum<RemindersAddErrorEnum>
{
    private RemindersAddErrorEnum(string value) : base(value)
    {
    }

    public static readonly RemindersAddErrorEnum CannotParse = new("cannot_parse");

    public static readonly RemindersAddErrorEnum UserNotFound = new("user_not_found");

    public static readonly RemindersAddErrorEnum CannotAddBot = new("cannot_add_bot");

    public static readonly RemindersAddErrorEnum CannotAddSlackbot = new("cannot_add_slackbot");

    public static readonly RemindersAddErrorEnum CannotAddOthers = new("cannot_add_others");

    public static readonly RemindersAddErrorEnum CannotAddOthersRecurring = new("cannot_add_others_recurring");

    public static readonly RemindersAddErrorEnum NotAuthed = new("not_authed");

    public static readonly RemindersAddErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly RemindersAddErrorEnum AccountInactive = new("account_inactive");

    public static readonly RemindersAddErrorEnum TokenRevoked = new("token_revoked");

    public static readonly RemindersAddErrorEnum NoPermission = new("no_permission");

    public static readonly RemindersAddErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly RemindersAddErrorEnum UserIsBot = new("user_is_bot");

    public static readonly RemindersAddErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly RemindersAddErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly RemindersAddErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly RemindersAddErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly RemindersAddErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly RemindersAddErrorEnum MissingPostType = new("missing_post_type");

    public static readonly RemindersAddErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly RemindersAddErrorEnum InvalidJson = new("invalid_json");

    public static readonly RemindersAddErrorEnum JsonNotObject = new("json_not_object");

    public static readonly RemindersAddErrorEnum RequestTimeout = new("request_timeout");

    public static readonly RemindersAddErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly RemindersAddErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onCannotParse,
        Func<TResult> onUserNotFound,
        Func<TResult> onCannotAddBot,
        Func<TResult> onCannotAddSlackbot,
        Func<TResult> onCannotAddOthers,
        Func<TResult> onCannotAddOthersRecurring,
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
            _ when this == CannotParse => onCannotParse(),
            _ when this == UserNotFound => onUserNotFound(),
            _ when this == CannotAddBot => onCannotAddBot(),
            _ when this == CannotAddSlackbot => onCannotAddSlackbot(),
            _ when this == CannotAddOthers => onCannotAddOthers(),
            _ when this == CannotAddOthersRecurring => onCannotAddOthersRecurring(),
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

    public void Match(Action onCannotParse,
        Action onUserNotFound,
        Action onCannotAddBot,
        Action onCannotAddSlackbot,
        Action onCannotAddOthers,
        Action onCannotAddOthersRecurring,
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
        if (this == CannotParse) onCannotParse();
        else if (this == UserNotFound) onUserNotFound();
        else if (this == CannotAddBot) onCannotAddBot();
        else if (this == CannotAddSlackbot) onCannotAddSlackbot();
        else if (this == CannotAddOthers) onCannotAddOthers();
        else if (this == CannotAddOthersRecurring) onCannotAddOthersRecurring();
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
