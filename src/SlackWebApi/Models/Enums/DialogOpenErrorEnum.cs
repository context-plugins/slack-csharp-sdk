using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DialogOpenErrorEnum>))]
public sealed record DialogOpenErrorEnum : OpenStringEnum<DialogOpenErrorEnum>
{
    private DialogOpenErrorEnum(string value) : base(value)
    {
    }

    public static readonly DialogOpenErrorEnum ValidationErrors = new("validation_errors");

    public static readonly DialogOpenErrorEnum MissingTrigger = new("missing_trigger");

    public static readonly DialogOpenErrorEnum MissingDialog = new("missing_dialog");

    public static readonly DialogOpenErrorEnum TriggerExchanged = new("trigger_exchanged");

    public static readonly DialogOpenErrorEnum TriggerExpired = new("trigger_expired");

    public static readonly DialogOpenErrorEnum InvalidTrigger = new("invalid_trigger");

    public static readonly DialogOpenErrorEnum AppMissingActionUrl = new("app_missing_action_url");

    public static readonly DialogOpenErrorEnum CannotCreateDialog = new("cannot_create_dialog");

    public static readonly DialogOpenErrorEnum FailedSendingDialog = new("failed_sending_dialog");

    public static readonly DialogOpenErrorEnum NotAuthed = new("not_authed");

    public static readonly DialogOpenErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly DialogOpenErrorEnum AccountInactive = new("account_inactive");

    public static readonly DialogOpenErrorEnum TokenRevoked = new("token_revoked");

    public static readonly DialogOpenErrorEnum NoPermission = new("no_permission");

    public static readonly DialogOpenErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly DialogOpenErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly DialogOpenErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly DialogOpenErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly DialogOpenErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly DialogOpenErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly DialogOpenErrorEnum MissingPostType = new("missing_post_type");

    public static readonly DialogOpenErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly DialogOpenErrorEnum InvalidJson = new("invalid_json");

    public static readonly DialogOpenErrorEnum JsonNotObject = new("json_not_object");

    public static readonly DialogOpenErrorEnum RequestTimeout = new("request_timeout");

    public static readonly DialogOpenErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly DialogOpenErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onValidationErrors,
        Func<TResult> onMissingTrigger,
        Func<TResult> onMissingDialog,
        Func<TResult> onTriggerExchanged,
        Func<TResult> onTriggerExpired,
        Func<TResult> onInvalidTrigger,
        Func<TResult> onAppMissingActionUrl,
        Func<TResult> onCannotCreateDialog,
        Func<TResult> onFailedSendingDialog,
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
            _ when this == ValidationErrors => onValidationErrors(),
            _ when this == MissingTrigger => onMissingTrigger(),
            _ when this == MissingDialog => onMissingDialog(),
            _ when this == TriggerExchanged => onTriggerExchanged(),
            _ when this == TriggerExpired => onTriggerExpired(),
            _ when this == InvalidTrigger => onInvalidTrigger(),
            _ when this == AppMissingActionUrl => onAppMissingActionUrl(),
            _ when this == CannotCreateDialog => onCannotCreateDialog(),
            _ when this == FailedSendingDialog => onFailedSendingDialog(),
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

    public void Match(Action onValidationErrors,
        Action onMissingTrigger,
        Action onMissingDialog,
        Action onTriggerExchanged,
        Action onTriggerExpired,
        Action onInvalidTrigger,
        Action onAppMissingActionUrl,
        Action onCannotCreateDialog,
        Action onFailedSendingDialog,
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
        if (this == ValidationErrors) onValidationErrors();
        else if (this == MissingTrigger) onMissingTrigger();
        else if (this == MissingDialog) onMissingDialog();
        else if (this == TriggerExchanged) onTriggerExchanged();
        else if (this == TriggerExpired) onTriggerExpired();
        else if (this == InvalidTrigger) onInvalidTrigger();
        else if (this == AppMissingActionUrl) onAppMissingActionUrl();
        else if (this == CannotCreateDialog) onCannotCreateDialog();
        else if (this == FailedSendingDialog) onFailedSendingDialog();
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
