using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChatPostMessageErrorEnum>))]
public sealed record ChatPostMessageErrorEnum : OpenStringEnum<ChatPostMessageErrorEnum>
{
    private ChatPostMessageErrorEnum(string value) : base(value)
    {
    }

    public static readonly ChatPostMessageErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ChatPostMessageErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ChatPostMessageErrorEnum IsArchived = new("is_archived");

    public static readonly ChatPostMessageErrorEnum MsgTooLong = new("msg_too_long");

    public static readonly ChatPostMessageErrorEnum NoText = new("no_text");

    public static readonly ChatPostMessageErrorEnum TooManyAttachments = new("too_many_attachments");

    public static readonly ChatPostMessageErrorEnum RateLimited = new("rate_limited");

    public static readonly ChatPostMessageErrorEnum NotAuthed = new("not_authed");

    public static readonly ChatPostMessageErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ChatPostMessageErrorEnum AccountInactive = new("account_inactive");

    public static readonly ChatPostMessageErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ChatPostMessageErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ChatPostMessageErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ChatPostMessageErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ChatPostMessageErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ChatPostMessageErrorEnum MissingPostType = new("missing_post_type");

    public TResult Match<TResult>(Func<TResult> onChannelNotFound,
        Func<TResult> onNotInChannel,
        Func<TResult> onIsArchived,
        Func<TResult> onMsgTooLong,
        Func<TResult> onNoText,
        Func<TResult> onTooManyAttachments,
        Func<TResult> onRateLimited,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == IsArchived => onIsArchived(),
            _ when this == MsgTooLong => onMsgTooLong(),
            _ when this == NoText => onNoText(),
            _ when this == TooManyAttachments => onTooManyAttachments(),
            _ when this == RateLimited => onRateLimited(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ => otherwise(Value)
        };

    public void Match(Action onChannelNotFound,
        Action onNotInChannel,
        Action onIsArchived,
        Action onMsgTooLong,
        Action onNoText,
        Action onTooManyAttachments,
        Action onRateLimited,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action<string> otherwise)
    {
        if (this == ChannelNotFound) onChannelNotFound();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == IsArchived) onIsArchived();
        else if (this == MsgTooLong) onMsgTooLong();
        else if (this == NoText) onNoText();
        else if (this == TooManyAttachments) onTooManyAttachments();
        else if (this == RateLimited) onRateLimited();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else otherwise(Value);
    }
}
