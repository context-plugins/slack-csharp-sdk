using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatScheduleMessageErrorEnum>))]
public sealed record ChatScheduleMessageErrorEnum : OpenStringEnum<ChatScheduleMessageErrorEnum>
{
    private ChatScheduleMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatScheduleMessageErrorEnum InvalidTime = new("invalid_time");

    public static readonly ChatScheduleMessageErrorEnum TimeInPast = new("time_in_past");

    public static readonly ChatScheduleMessageErrorEnum TimeTooFar = new("time_too_far");

    public static readonly ChatScheduleMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatScheduleMessageErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ChatScheduleMessageErrorEnum IsArchived = new("is_archived");

    public static readonly ChatScheduleMessageErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatScheduleMessageErrorEnum NoText = new("no_text");

    public static readonly ChatScheduleMessageErrorEnum RestrictedAction = new("restricted_action");

    public static readonly ChatScheduleMessageErrorEnum RestrictedActionReadOnlyChannel = new(
        "restricted_action_read_only_channel");

    public static readonly ChatScheduleMessageErrorEnum RestrictedActionThreadOnlyChannel = new(
        "restricted_action_thread_only_channel");

    public static readonly ChatScheduleMessageErrorEnum RestrictedActionNonThreadableChannel = new(
        "restricted_action_non_threadable_channel");

    public static readonly ChatScheduleMessageErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatScheduleMessageErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatScheduleMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatScheduleMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatScheduleMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatScheduleMessageErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatScheduleMessageErrorEnum NoPermission = new("no_permission");

    public static readonly ChatScheduleMessageErrorEnum OrgLoginRequired = new("org_login_required");

    public static readonly ChatScheduleMessageErrorEnum EkmAccessDenied = new("ekm_access_denied");

    public static readonly ChatScheduleMessageErrorEnum MissingScope = new("missing_scope");

    public static readonly ChatScheduleMessageErrorEnum InvalidArguments = new("invalid_arguments");

    public static readonly ChatScheduleMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatScheduleMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatScheduleMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatScheduleMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatScheduleMessageErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatScheduleMessageErrorEnum TeamAddedToOrg = new("team_added_to_org");

    public static readonly ChatScheduleMessageErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatScheduleMessageErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatScheduleMessageErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatScheduleMessageErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatScheduleMessageErrorEnum FatalError = new("fatal_error");

    public TResult Match<TResult>(Func<TResult> onInvalidTime,
        Func<TResult> onTimeInPast,
        Func<TResult> onTimeTooFar,
        Func<TResult> onChannelNotFound,
        Func<TResult> onNotInChannel,
        Func<TResult> onIsArchived,
        Func<TResult> onMsgTooLong,
        Func<TResult> onNoText,
        Func<TResult> onRestrictedAction,
        Func<TResult> onRestrictedActionReadOnlyChannel,
        Func<TResult> onRestrictedActionThreadOnlyChannel,
        Func<TResult> onRestrictedActionNonThreadableChannel,
        Func<TResult> onTooManyAttachments,
        Func<TResult> onRateLimited,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onOrgLoginRequired,
        Func<TResult> onEkmAccessDenied,
        Func<TResult> onMissingScope,
        Func<TResult> onInvalidArguments,
        Func<TResult> onInvalidArgName,
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
            _ when this == InvalidTime => onInvalidTime(),
            _ when this == TimeInPast => onTimeInPast(),
            _ when this == TimeTooFar => onTimeTooFar(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == IsArchived => onIsArchived(),
            _ when this == MsgTooLong => onMsgTooLong(),
            _ when this == NoText => onNoText(),
            _ when this == RestrictedAction => onRestrictedAction(),
            _ when this == RestrictedActionReadOnlyChannel => onRestrictedActionReadOnlyChannel(),
            _ when this == RestrictedActionThreadOnlyChannel => onRestrictedActionThreadOnlyChannel(),
            _ when this == RestrictedActionNonThreadableChannel => onRestrictedActionNonThreadableChannel(),
            _ when this == TooManyAttachments => onTooManyAttachments(),
            _ when this == RateLimited => onRateLimited(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == OrgLoginRequired => onOrgLoginRequired(),
            _ when this == EkmAccessDenied => onEkmAccessDenied(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == InvalidArguments => onInvalidArguments(),
            _ when this == InvalidArgName => onInvalidArgName(),
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

    public void Match(Action onInvalidTime,
        Action onTimeInPast,
        Action onTimeTooFar,
        Action onChannelNotFound,
        Action onNotInChannel,
        Action onIsArchived,
        Action onMsgTooLong,
        Action onNoText,
        Action onRestrictedAction,
        Action onRestrictedActionReadOnlyChannel,
        Action onRestrictedActionThreadOnlyChannel,
        Action onRestrictedActionNonThreadableChannel,
        Action onTooManyAttachments,
        Action onRateLimited,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onOrgLoginRequired,
        Action onEkmAccessDenied,
        Action onMissingScope,
        Action onInvalidArguments,
        Action onInvalidArgName,
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
        if (this == InvalidTime) onInvalidTime();
        else if (this == TimeInPast) onTimeInPast();
        else if (this == TimeTooFar) onTimeTooFar();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == IsArchived) onIsArchived();
        else if (this == MsgTooLong) onMsgTooLong();
        else if (this == NoText) onNoText();
        else if (this == RestrictedAction) onRestrictedAction();
        else if (this == RestrictedActionReadOnlyChannel) onRestrictedActionReadOnlyChannel();
        else if (this == RestrictedActionThreadOnlyChannel) onRestrictedActionThreadOnlyChannel();
        else if (this == RestrictedActionNonThreadableChannel) onRestrictedActionNonThreadableChannel();
        else if (this == TooManyAttachments) onTooManyAttachments();
        else if (this == RateLimited) onRateLimited();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == OrgLoginRequired) onOrgLoginRequired();
        else if (this == EkmAccessDenied) onEkmAccessDenied();
        else if (this == MissingScope) onMissingScope();
        else if (this == InvalidArguments) onInvalidArguments();
        else if (this == InvalidArgName) onInvalidArgName();
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
