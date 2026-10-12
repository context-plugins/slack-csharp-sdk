using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatUpdateErrorEnum>))]
public sealed record ChatUpdateErrorEnum : OpenStringEnum<ChatUpdateErrorEnum>
{
    private ChatUpdateErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatUpdateErrorEnum MessageNotFound = new("message_not_found");

    public static readonly ChatUpdateErrorEnum CantUpdateMessage = new("cant_update_message");

    public static readonly ChatUpdateErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatUpdateErrorEnum EditWindowClosed = new("edit_window_closed");

    public static readonly ChatUpdateErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatUpdateErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatUpdateErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatUpdateErrorEnum NoText = new("no_text");

    public static readonly ChatUpdateErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatUpdateErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatUpdateErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatUpdateErrorEnum TokenRevoked = new("token_revoked");

    public static readonly ChatUpdateErrorEnum NoPermission = new("no_permission");

    public static readonly ChatUpdateErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatUpdateErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatUpdateErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatUpdateErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatUpdateErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatUpdateErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ChatUpdateErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ChatUpdateErrorEnum InvalidJson = new("invalid_json");

    public static readonly ChatUpdateErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ChatUpdateErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ChatUpdateErrorEnum FatalError = new("fatal_error");

    public static readonly ChatUpdateErrorEnum IsInactive = new("is_inactive");

    public TResult Match<TResult>(Func<TResult> onMessageNotFound,
        Func<TResult> onCantUpdateMessage,
        Func<TResult> onChannelNotFound,
        Func<TResult> onEditWindowClosed,
        Func<TResult> onMsgTooLong,
        Func<TResult> onTooManyAttachments,
        Func<TResult> onRateLimited,
        Func<TResult> onNoText,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onTokenRevoked,
        Func<TResult> onNoPermission,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onRequestTimeout,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onUpgradeRequired,
        Func<TResult> onFatalError,
        Func<TResult> onIsInactive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MessageNotFound => onMessageNotFound(),
            _ when this == CantUpdateMessage => onCantUpdateMessage(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == EditWindowClosed => onEditWindowClosed(),
            _ when this == MsgTooLong => onMsgTooLong(),
            _ when this == TooManyAttachments => onTooManyAttachments(),
            _ when this == RateLimited => onRateLimited(),
            _ when this == NoText => onNoText(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == TokenRevoked => onTokenRevoked(),
            _ when this == NoPermission => onNoPermission(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ when this == FatalError => onFatalError(),
            _ when this == IsInactive => onIsInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onMessageNotFound,
        Action onCantUpdateMessage,
        Action onChannelNotFound,
        Action onEditWindowClosed,
        Action onMsgTooLong,
        Action onTooManyAttachments,
        Action onRateLimited,
        Action onNoText,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onTokenRevoked,
        Action onNoPermission,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onRequestTimeout,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onUpgradeRequired,
        Action onFatalError,
        Action onIsInactive,
        Action<string> otherwise)
    {
        if (this == MessageNotFound) onMessageNotFound();
        else if (this == CantUpdateMessage) onCantUpdateMessage();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == EditWindowClosed) onEditWindowClosed();
        else if (this == MsgTooLong) onMsgTooLong();
        else if (this == TooManyAttachments) onTooManyAttachments();
        else if (this == RateLimited) onRateLimited();
        else if (this == NoText) onNoText();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == TokenRevoked) onTokenRevoked();
        else if (this == NoPermission) onNoPermission();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else if (this == FatalError) onFatalError();
        else if (this == IsInactive) onIsInactive();
        else otherwise(Value);
    }
}
