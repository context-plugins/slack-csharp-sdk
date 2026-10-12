using System;
using System.Text.Json.Serialization;
using SlackWebApi.Core.Enum;

namespace SlackWebApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ConversationsMarkErrorEnum>))]
public sealed record ConversationsMarkErrorEnum : OpenStringEnum<ConversationsMarkErrorEnum>
{
    private ConversationsMarkErrorEnum(string value) : base(value)
    {
    }

    public static readonly ConversationsMarkErrorEnum MethodNotSupportedForChannelType = new(
        "method_not_supported_for_channel_type");

    public static readonly ConversationsMarkErrorEnum MissingScope = new("missing_scope");

    public static readonly ConversationsMarkErrorEnum ChannelNotFound = new("channel_not_found");

    public static readonly ConversationsMarkErrorEnum InvalidTimestamp = new("invalid_timestamp");

    public static readonly ConversationsMarkErrorEnum NotInChannel = new("not_in_channel");

    public static readonly ConversationsMarkErrorEnum NotAuthed = new("not_authed");

    public static readonly ConversationsMarkErrorEnum InvalidAuth = new("invalid_auth");

    public static readonly ConversationsMarkErrorEnum AccountInactive = new("account_inactive");

    public static readonly ConversationsMarkErrorEnum InvalidArgName = new("invalid_arg_name");

    public static readonly ConversationsMarkErrorEnum InvalidArrayArg = new("invalid_array_arg");

    public static readonly ConversationsMarkErrorEnum InvalidCharset = new("invalid_charset");

    public static readonly ConversationsMarkErrorEnum InvalidFormData = new("invalid_form_data");

    public static readonly ConversationsMarkErrorEnum InvalidPostType = new("invalid_post_type");

    public static readonly ConversationsMarkErrorEnum MissingPostType = new("missing_post_type");

    public static readonly ConversationsMarkErrorEnum InvalidJson = new("invalid_json");

    public static readonly ConversationsMarkErrorEnum JsonNotObject = new("json_not_object");

    public static readonly ConversationsMarkErrorEnum RequestTimeout = new("request_timeout");

    public static readonly ConversationsMarkErrorEnum UpgradeRequired = new("upgrade_required");

    public static readonly ConversationsMarkErrorEnum NotAllowedTokenType = new("not_allowed_token_type");

    public TResult Match<TResult>(Func<TResult> onMethodNotSupportedForChannelType,
        Func<TResult> onMissingScope,
        Func<TResult> onChannelNotFound,
        Func<TResult> onInvalidTimestamp,
        Func<TResult> onNotInChannel,
        Func<TResult> onNotAuthed,
        Func<TResult> onInvalidAuth,
        Func<TResult> onAccountInactive,
        Func<TResult> onInvalidArgName,
        Func<TResult> onInvalidArrayArg,
        Func<TResult> onInvalidCharset,
        Func<TResult> onInvalidFormData,
        Func<TResult> onInvalidPostType,
        Func<TResult> onMissingPostType,
        Func<TResult> onInvalidJson,
        Func<TResult> onJsonNotObject,
        Func<TResult> onRequestTimeout,
        Func<TResult> onUpgradeRequired,
        Func<TResult> onNotAllowedTokenType,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MethodNotSupportedForChannelType => onMethodNotSupportedForChannelType(),
            _ when this == MissingScope => onMissingScope(),
            _ when this == ChannelNotFound => onChannelNotFound(),
            _ when this == InvalidTimestamp => onInvalidTimestamp(),
            _ when this == NotInChannel => onNotInChannel(),
            _ when this == NotAuthed => onNotAuthed(),
            _ when this == InvalidAuth => onInvalidAuth(),
            _ when this == AccountInactive => onAccountInactive(),
            _ when this == InvalidArgName => onInvalidArgName(),
            _ when this == InvalidArrayArg => onInvalidArrayArg(),
            _ when this == InvalidCharset => onInvalidCharset(),
            _ when this == InvalidFormData => onInvalidFormData(),
            _ when this == InvalidPostType => onInvalidPostType(),
            _ when this == MissingPostType => onMissingPostType(),
            _ when this == InvalidJson => onInvalidJson(),
            _ when this == JsonNotObject => onJsonNotObject(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == UpgradeRequired => onUpgradeRequired(),
            _ when this == NotAllowedTokenType => onNotAllowedTokenType(),
            _ => otherwise(Value)
        };

    public void Match(Action onMethodNotSupportedForChannelType,
        Action onMissingScope,
        Action onChannelNotFound,
        Action onInvalidTimestamp,
        Action onNotInChannel,
        Action onNotAuthed,
        Action onInvalidAuth,
        Action onAccountInactive,
        Action onInvalidArgName,
        Action onInvalidArrayArg,
        Action onInvalidCharset,
        Action onInvalidFormData,
        Action onInvalidPostType,
        Action onMissingPostType,
        Action onInvalidJson,
        Action onJsonNotObject,
        Action onRequestTimeout,
        Action onUpgradeRequired,
        Action onNotAllowedTokenType,
        Action<string> otherwise)
    {
        if (this == MethodNotSupportedForChannelType) onMethodNotSupportedForChannelType();
        else if (this == MissingScope) onMissingScope();
        else if (this == ChannelNotFound) onChannelNotFound();
        else if (this == InvalidTimestamp) onInvalidTimestamp();
        else if (this == NotInChannel) onNotInChannel();
        else if (this == NotAuthed) onNotAuthed();
        else if (this == InvalidAuth) onInvalidAuth();
        else if (this == AccountInactive) onAccountInactive();
        else if (this == InvalidArgName) onInvalidArgName();
        else if (this == InvalidArrayArg) onInvalidArrayArg();
        else if (this == InvalidCharset) onInvalidCharset();
        else if (this == InvalidFormData) onInvalidFormData();
        else if (this == InvalidPostType) onInvalidPostType();
        else if (this == MissingPostType) onMissingPostType();
        else if (this == InvalidJson) onInvalidJson();
        else if (this == JsonNotObject) onJsonNotObject();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == UpgradeRequired) onUpgradeRequired();
        else if (this == NotAllowedTokenType) onNotAllowedTokenType();
        else otherwise(Value);
    }
}
